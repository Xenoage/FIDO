using Fido;
using Fido.Model;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.ComponentModel;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers().AddJsonOptions(options => {
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});
builder.Services.AddSwaggerGen(options => {
    options.DocumentFilter<AdditionalSchemasDocumentFilter>();
    options.SchemaFilter<DescriptionSchemaFilter>();
    options.SwaggerDoc("v1", new OpenApiInfo {
        Version = "0.1",
        Title = FidoSpec.Title,
        Description = FidoSpec.Description,
        Contact = new OpenApiContact {
            Name = "Xenoage Software",
            Email = "info@xenoage.com",
            Url = new Uri("https://www.xenoage.com"),
        }
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI(c => {
        c.DocumentTitle = "FIDO Specification";
        c.DefaultModelsExpandDepth(5);
    });
}

app.Run();


/// <summary>
/// Included models.
/// </summary>
internal class AdditionalSchemasDocumentFilter : IDocumentFilter {
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context) {
        context.SchemaGenerator.GenerateSchema(typeof(FuneralCase), context.SchemaRepository);
    }
}

/// <summary>
/// Use the [Description] attribute as a source for Swashbuckle documentation.
/// Source: https://stackoverflow.com/a/72129777/518491
/// </summary>
internal class DescriptionSchemaFilter : ISchemaFilter {

    public void Apply(OpenApiSchema schema, SchemaFilterContext context) {
        if (context.ParameterInfo != null) {
            var descriptionAttributes = context.ParameterInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (descriptionAttributes.Length > 0) {
                var descriptionAttribute = (DescriptionAttribute)descriptionAttributes[0];
                schema.Description = descriptionAttribute.Description;
            }
        }

        if (context.MemberInfo != null) {
            var descriptionAttributes = context.MemberInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (descriptionAttributes.Length > 0) {
                var descriptionAttribute = (DescriptionAttribute)descriptionAttributes[0];
                schema.Description = descriptionAttribute.Description;
            }
        }

        if (context.Type != null) {
            var descriptionAttributes = context.Type.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (descriptionAttributes.Length > 0) {
                var descriptionAttribute = (DescriptionAttribute)descriptionAttributes[0];
                schema.Description = descriptionAttribute.Description;
            }

        }
    }
}