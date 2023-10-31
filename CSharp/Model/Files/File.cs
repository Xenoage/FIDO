using System.ComponentModel;

namespace Fido.Model.Files;

/// <summary>
/// A file attached to the funeral case,
/// e.g. a document in PDF format, a photo in JPG format,
/// or any other file type.
/// </summary>
[Description("Files.File")] // Required for JSON Schema documentation generator
public record File {

    /// <summary>
    /// File name, with extension, but without a path.
    /// For example "Condolence Card.jpg".
    /// Should be unique  within the list of files to make it possible to reference this file.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Media type of the file, as defined in
    /// https://www.iana.org/assignments/media-types/media-types.xhtml .
    /// For example "application/pdf" for a PDF file or "image/jpeg" for a JPEG image.
    /// May be omitted if unknown or for custom file formats,
    /// like funeral software specific formats.
    /// </summary>
    public string? MimeType { get; init; }

    /// <summary>
    /// SHA-256 hash of the file content in hexadecimal format (lowercase letters).
    /// If this property is set, the receiver of the file can for example
    /// immediately determine if he already knows this file, without having to download
    /// the whole file data.
    /// </summary>
    public string? Hash { get; init; }

    /// <summary>
    /// Specifies how the file is encoded in the Data property.
    /// </summary>
    public required FileType Type { get; init; }

    /// <summary>
    /// File content or source, as specified in the Type property.
    /// </summary>
    public required string Data { get; init; }

}
