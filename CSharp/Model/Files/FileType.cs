namespace Fido.Model.Files;

/// <summary>
/// Different ways to refer to file content.
/// </summary>
public enum FileType {

    /// <summary>
    /// The file content is directly embedded in base64url encoding
    /// (see https://datatracker.ietf.org/doc/html/rfc4648#section-5).
    /// This is the recommended way to share the whole data of a funeral case
    /// within a single JSON file and aims for maximum interoperability.
    /// However, the JSON file may become quite large.
    /// For each embedded file, about 133% of its size is required when
    /// storing the data in base64url format.
    /// </summary>
    Embedded,

    /// <summary>
    /// The file content can be found at the given URL,
    /// e.g. https://storage.funeralapp.com/sf-0001/card.pdf?token=somesecretkey".
    /// This is the recommended way when the JSON file should be kept small and
    /// when the other software programs using this file are expected to have an
    /// internet connection. However, there is overhead to upload the file content
    /// to some server and make it available, if required also protected from public
    /// access in some way, like a token as in the example above.
    /// For maximum interoperability, prefer embedding the file content using the
    /// <see cref="Embedded"/> file type.
    /// </summary>
    Url,

    /// <summary>
    /// The file content can be found on the local computer at the given
    /// absolute path, e.g. "C:\Funeral Cases\SF-0001\Condolence Card.docx" on Windows
    /// or "/Users/Max/Funeral Cases/SF-0001/Condolence Card.docx" on Mac OS X
    /// or "/home/Max/Funeral Cases/SF-0001/Condolence Card.docx" on Linux.
    /// This file type should only be used within a local communication between
    /// programs on the same machine.
    /// For maximum interoperability, prefer embedding the file content using the
    /// <see cref="Embedded"/> file type.
    /// </summary>
    LocalFile

}
