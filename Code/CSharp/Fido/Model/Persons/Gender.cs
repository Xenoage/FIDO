using System.ComponentModel;

namespace Fido.Model.Persons;

/// <summary>
/// List of genders.
/// </summary>
[Description("Persons.Gender")] // Required for JSON Schema documentation generator
public enum Gender {
    Male,
    Female,
    Other
}