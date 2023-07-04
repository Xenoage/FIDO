using System.ComponentModel;

namespace Fido.Model.Persons;

/// <summary>
/// The role of a person involved in the funeral case.
/// </summary>
[Description("Persons.Role")] // Required for JSON Schema documentation generator
public enum Role {

    /// <summary>
    /// The person, often from the family, who contacts and engages
    /// with the funeral home to make the necessary arrangements.
    /// </summary>
    ContactPerson,

    /// <summary>
    /// The person or institution who has to pay for the funeral.
    /// Often, this will be the same one as the <see cref="ContactPerson"/>.
    /// </summary>
    Payer,

}
