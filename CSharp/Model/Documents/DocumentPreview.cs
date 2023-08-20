using Fido.Model.Files;
using System.ComponentModel;

namespace Fido.Model.Documents;

/// <summary>
/// A preview image of a document.
/// </summary>
[Description("Documents.DocumentPreview")] // Required for JSON Schema documentation generator
public record DocumentPreview {

    /// <summary>
    /// Optionally, the page number of the preview, starting with "1".
    /// If the document is a single sheet with an inner and outer side,
    /// like for a memorial card, also the values "Inside" and "Outside"
    /// can be used here.
    /// </summary>
    public string? Page { get; init; }

    /// <summary>
    /// The file content, referenced by file name.
    /// The file is stored in the Files property in the root object.
    /// </summary>
    public required string FileName { get; init; }

}