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
    /// The list of all persons, including the deceased.
    /// </summary>
    public required List<Person> Persons { get; init; }

}