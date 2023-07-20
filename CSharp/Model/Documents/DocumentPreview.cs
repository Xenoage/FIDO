using Fido.Model.Files;

namespace Fido.Model.Documents;

/// <summary>
/// A preview image of a <see cref="Document"/>.
/// </summary>
public record DocumentPreview {

    /// <summary>
    /// Optionally, the page number of the preview, starting with "1".
    /// If the document is a single sheet with an inner and outer side,
    /// like for a memorial card, also the values "Inside" and "Outside"
    /// can be used here.
    /// </summary>
    public string? Page { get; init; }

    /// <summary>
    /// The file content.
    /// </summary>
    public required File File { get; init; }

}