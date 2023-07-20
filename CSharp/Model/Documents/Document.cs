using Fido.Model.Files;
using Fido.Model.Persons;
using System.Collections.Generic;

namespace Fido.Model.Documents;

/// <summary>
/// A document related to a funeral case.
/// Some examples are a death notification ("Sterbefallanzeige" in German),
/// an order confirmation, a bill or a memorial card ("Trauerkarte" in German).
/// A document consists of a name and a file, optionally including preview images.
/// </summary>
public record Document {

    /// <summary>
    /// The name of the document, e.g. "Sterbefallanzeige" for a
    /// death notification in a German funeral case.
    /// The possible names are not defined within the FIDO format due to
    /// the vast variety arising from national and even regional differences.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// The files belonging to this document.
    /// </summary>
    public File? File { get; init; }

    /// <summary>
    /// Optionally, the list of preview images for this document.
    /// For example, there could be a JPG preview of page 1,
    /// and a PNG preview also for page 1 and for page 2.
    /// </summary>
    public List<DocumentPreview>? Previews { get; init; }

}