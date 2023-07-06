using System.ComponentModel;

namespace Fido.Model.Files;

/// <summary>
/// A file attached to the funeral case,
/// e.g. a document in PDF format, a photo in JPG format,
/// or any other file type.
/// </summary>
[Description("Files.File")] // Required for JSON Schema documentation generator
public class File {

    /// <summary>
    /// File name, with extension, but without a path.
    /// For example "Condolence Card.jpg".
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Specifies how the file is encoded in the Data property.
    /// </summary>
    public required FileType Type { get; init; }

    /// <summary>
    /// File content or source, as specified in the Type property.
    /// </summary>
    public required string Data { get; init; }

}
