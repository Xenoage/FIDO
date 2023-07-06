namespace Fido.Model.Files;

/// <summary>
/// Different ways to refer to file content.
/// </summary>
public enum FileType {

    /// <summary>
    /// The file content is directly embedded in Base64 encoding
    /// (see https://datatracker.ietf.org/doc/html/rfc4648)
    /// into the File.Data property.
    /// This is the recommended way to share all files of a funeral case
    /// within a single JSON object and aims for maximum interoperability.
    /// However, the JSON object may become quite large.
    /// For each embedded file, about 133% of its original size is required
    /// when storing the data in Base64 format.
    /// </summary>
    Base64,

    /// <summary>
    /// The file content can be found at the URL given in the File.Data property,
    /// e.g. https://storage.funeralapp.com/sf-0001/card.pdf?token=somesecretkey".
    /// This is the recommended way when the JSON file should be kept small and
    /// when the other software programs using this file are expected to be
    /// connected to the internet. However, there is overhead to upload the file content
    /// to some server and make it available, if required also protected from public
    /// access in some way, like a token as in the example above.
    /// Alternatively, but for local communication only, a local webserver could
    /// be spawned which serves the file at the given localhost URL.
    /// For maximum interoperability, prefer embedding the file content using the
    /// Base64 file type.
    /// </summary>
    Url,

    /// <summary>
    /// The file content can be found on the local computer at the
    /// absolute path given in the File.Data property,
    /// e.g. "C:\Funeral Cases\SF-0001\Condolence Card.docx" on Windows
    /// or "/Users/Max/Funeral Cases/SF-0001/Condolence Card.docx" on Mac OS X
    /// or "/home/Max/Funeral Cases/SF-0001/Condolence Card.docx" on Linux.
    /// This file type should only be used within a local communication between
    /// programs on the same machine.
    /// For maximum interoperability, prefer embedding the file content using the
    /// Base64 file type.
    /// </summary>
    LocalFile

}
