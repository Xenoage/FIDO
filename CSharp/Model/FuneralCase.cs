using Fido.Model.Persons;
using System.ComponentModel;

namespace Fido.Model;

/// <summary>
/// In German: Bestattungsfall.
/// 
/// A funeral case is specific individual case in which a funeral
/// is conducted by a funeral home. The term encompasses the entire process
/// of organizing and carrying out a funeral, including the formalities,
/// coordination with relatives, preparation of the deceased,
/// funeral ceremony, and burial.
/// 
/// This is the basic data structure containing the personal data of the
/// deceased and other involved persons, appointments and documents.
/// </summary>
[Description("FuneralCase")] // Required for JSON Schema documentation generator
public record FuneralCase {

    /// <summary>
    /// The same funeral case may have different IDs in the
    /// used software components. In this data structure, the
    /// ID of each involved software is stored. This allows each
    /// application involved in the funeral process to identify
    /// the funeral case in its own database when it comes back
    /// from another software. Each software may add its own ID here,
    /// but should never change the ID of other programs.
    /// </summary>
    public required List<Identification> Identification { get; init; }

    /// <summary>
    /// The list of all persons, including the deceased.
    /// </summary>
    public required List<Person> Persons { get; init; }

}