using Fido.Model;
using Newtonsoft.Json.Schema.Generation;
using Newtonsoft.Json.Serialization;

// Create the JSON Schema (https://json-schema.org/) from
// the data model, and save it to "FIDO.schema.json"
var generator = new JSchemaGenerator();
generator.GenerationProviders.Add(new StringEnumGenerationProvider()); // enum as string
var schemaObj = generator.Generate(typeof(FuneralCase));
var schemaJson = schemaObj.ToString();
File.WriteAllText("FIDO.schema.json", schemaJson);