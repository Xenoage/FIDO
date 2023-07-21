using Fido;
using Fido.JsonSchema;
using Fido.Model;
using Fido.Model.Appointments;
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
schemaObj.Id = new Uri("https://www.fidoformat.org/spec/fido-0.1.schema.json");
schemaObj.Title = FidoSpec.Title;
schemaObj.Description = FidoSpec.Description;

// Collect descriptions for the classes
Dictionary<JSchema, string> descs = new();
foreach (var prop in schemaObj.Properties)
    CollectDescriptions("FuneralCase", prop.Key, prop.Value, descs);
foreach (var d in descs)
    d.Key.Description = d.Value;

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


// Helper function to collect JSON Schema description from XML Doc
void CollectDescriptions(string typeName, string? propertyName, JSchema value, Dictionary<JSchema, string> collectedDescriptions) {
    var asm = Assembly.GetAssembly(typeof(FidoSpec))!;
    try {
        string? description = (typeName, propertyName) switch {
            (string t, string p) => Clean(asm.GetType("Fido.Model." + t)?.GetProperty(p)?.GetSummary() ?? ""),
            (string t, _) => Clean(asm.GetType("Fido.Model." + t)?.GetSummary()),
            _ => null // $"Missing docs for {typeName} {propertyName}";
        };
        if (description != null)
            collectedDescriptions[value] = description;
    } catch {
    }
    foreach (var prop in value.Properties)
        CollectDescriptions(typeName, prop.Key, prop.Value, collectedDescriptions);
    foreach (var item in value.Items)
        CollectDescriptions(item.Description ?? "?", null, item, collectedDescriptions);
}

// Remove whitespace (line breaks and indentation)
string Clean(string s) =>
    Regex.Replace(s, @"\s+", " ");