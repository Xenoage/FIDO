using Fido;
using Fido.JsonSchema;
using Fido.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using System.Reflection;
using System.Text.RegularExpressions;

// Create the JSON Schema (https://json-schema.org/) from the data model

var generator = new JSchemaGenerator();
generator.DefaultRequired = Required.DisallowNull;
generator.GenerationProviders.Add(new StringEnumGenerationProvider()); // enum as string
var schemaObj = generator.Generate(typeof(FuneralCase));
schemaObj.Title = FidoSpec.Title;
schemaObj.Description = FidoSpec.Description;
foreach (var prop in schemaObj.Properties)
    CreateDesc("FuneralCase", prop.Key, prop.Value);

var writer = new StringWriter();
var jsonWriter = new JsonTextWriter(writer);
jsonWriter.Formatting = Formatting.Indented;
schemaObj.WriteTo(jsonWriter, new JSchemaWriterSettings {
    Version = SchemaVersion.Draft7
});
var schemaJson = writer.ToString();

// Save it to /JsonSchema/FIDO.schema.json
var dir = new DirectoryInfo(".");
while (dir.Parent != null && false == dir.GetDirectories().Any(subdir => subdir.Name == ".git")) { // Find repo root dir
    dir = dir.Parent;
}
File.WriteAllText(Path.Combine(dir.FullName, "JsonSchema/fido.schema.json"), schemaJson);


// Helper function to update JSON Schema description from XML Doc
void CreateDesc(string typeName, string? propertyName, JSchema value) {
    var asm = Assembly.GetAssembly(typeof(FidoSpec))!;
    try {
        value.Description = (typeName, propertyName) switch {
            (string t, string p) => Clean(asm.GetType("Fido.Model." + t)?.GetProperty(p)?.GetSummary() ?? ""),
            (string t, _) => Clean(asm.GetType("Fido.Model." + t)?.GetSummary()),
            _ => null // $"Missing docs for {typeName} {propertyName}";
        };
    } catch {
        value.Description = null; // $"Missing docs for {typeName} {propertyName}";
    }
    foreach (var prop in value.Properties)
        CreateDesc(typeName, prop.Key, prop.Value);
    foreach (var item in value.Items)
        CreateDesc(item.Description ?? "?", null, item);
}

// Remove whitespace (line breaks and indentation)
string Clean(string s) =>
    Regex.Replace(s, @"\s+", " ");