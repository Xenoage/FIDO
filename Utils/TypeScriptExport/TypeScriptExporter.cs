using Fido.Model.Stakeholders;
using Reinforced.Typings.Ast.TypeNames;
using Reinforced.Typings.Fluent;
using System.Reflection;

namespace Fido.TypeScriptExport;

public class TypeScriptExporter {

    public static void Configure(ConfigurationBuilder builder) {

        // Global settings
        builder.Global(x => x.RootNamespace("Fido"));
        builder.Global(x => x.GenerateDocumentation(true));
        builder.Global(x => x.DontWriteWarningComment(true));
        builder.Global(x => x.AutoOptionalProperties(true));
        builder.Global(x => x.UseModules(discardNamespaces: true));

        // Type substitutions
        builder.Substitute(typeof(DateOnly), new RtSimpleTypeName("string"));

        // Register assembly documentations
        builder.TryLookupDocumentationForAssembly(Assembly.Load("Fido"), "Fido.xml");

        // Register classes and interfaces to export. Export all classes as typescript interfaces.
        // We use the fluent API instead of C# attributes to avoid "pollution" of the C# files
        var types = new[] {
            typeof(Model.FuneralCase),
            typeof(Stakeholder),
            typeof(Model.Appointments.Appointment),
            typeof(Model.Documents.Document),
            typeof(Model.Documents.DocumentPreview),
            typeof(Model.Files.File),
            typeof(Model.Persons.Person),
        };
        builder.ExportAsInterfaces(types, it => it.WithPublicProperties().AutoI(false));

        // Register enums to export
        types = new[] {
            typeof(Model.Appointments.AppointmentType),
            typeof(Model.Files.FileType),
            typeof(Model.Persons.Gender),
            typeof(Model.Persons.Relationship),
            typeof(Model.Persons.Role),
        };
        builder.ExportAsEnums(types, it => it.UseString());

    }

}