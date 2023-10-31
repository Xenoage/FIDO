using System.Collections.Generic;
using System.ComponentModel;

namespace Fido.Model.Documents;

/// <summary>
/// A document related to a funeral case.
/// Some examples are a death notification ("Sterbefallanzeige" in German),
/// an order confirmation, a bill or a memorial card ("Trauerkarte" in German).
/// A document consists of a name and a file, optionally including preview images.
/// </summary>
[Description("Documents.Document")] // Required for JSON Schema documentation generator
public record Document {

    /// <summary>
    /// The name of the document, e.g. "Sterbefallanzeige" for a
    /// death notification in a German funeral case.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Type of the document, if known and defined in the FIDO format.
    /// Not all possible types can be defined within the FIDO format due to
    /// the vast variety arising from national and even regional differences.
    /// </summary>
    public DocumentType? Type { get; init; }

    /// <summary>
    /// The file belonging to this document, referenced by file name.
    /// The file is stored in the Files property in the root object.
    /// </summary>
    public string? FileName { get; init; }

    /// <summary>
    /// Optionally, the list of preview images for this document.
    /// For example, there could be a JPG preview of page 1,
    /// and a PNG preview also for page 1 and for page 2.
    /// </summary>
    public List<DocumentPreview>? Previews { get; init; }

}