using Fido;
using Fido.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;

// Create the JSON Schema (https://json-schema.org/) from
// the data model, and save it to "/JsonSchema/FIDO.schema.json"

var generator = new JSchemaGenerator();
generator.DefaultRequired = Required.DisallowNull;
generator.GenerationProviders.Add(new StringEnumGenerationProvider()); // enum as string
var schemaObj = generator.Generate(typeof(FuneralCase));
schemaObj.Title = FidoSpec.Title;
schemaObj.Description = FidoSpec.Description;

var writer = new StringWriter();
var jsonWriter = new JsonTextWriter(writer);
jsonWriter.Formatting = Formatting.Indented;
schemaObj.WriteTo(jsonWriter, new JSchemaWriterSettings {
    Version = SchemaVersion.Draft7
});
var schemaJson = writer.ToString();
var dir = new DirectoryInfo(".");
while (dir.Parent != null && false == dir.GetDirectories().Any(subdir => subdir.Name == ".git")) { // Find repo root dir
    dir = dir.Parent;
}
File.WriteAllText(Path.Combine(dir.FullName, "JsonSchema/FIDO.schema.json"), schemaJson);