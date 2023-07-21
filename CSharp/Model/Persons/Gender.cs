using System.ComponentModel;

namespace Fido.Model.Persons;

/// <summary>
/// List of genders.
/// </summary>
[Description("Persons.Gender")] // Required for JSON Schema documentation generator
public enum Gender {

    /// <summary>
    /// Male gender.
    /// </summary>
    Male,

    /// <summary>
    /// Female gender.
    /// </summary>
    Female,

    /// <summary>
    /// Other or unknown gender.
    /// </summary>
    Other
}