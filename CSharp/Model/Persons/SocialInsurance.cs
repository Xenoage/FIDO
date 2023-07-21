using System.ComponentModel;

namespace Fido.Model.Persons;

/// <summary>
/// The social security system is different for each country.
/// In this format, we store the name of the program and a number
/// identifying the person within this program.
/// </summary>
[Description("Persons.SocialInsurance")] // Required for JSON Schema documentation generator
public record SocialInsurance {

    /// <summary>
    /// The localized name of the social security system, e.g. in German
    /// "Krankenversicherung" (health insurance) or "Rentenversicherung" (pension insurance).
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// The number which identifies the person within this system.
    /// For example, a pension insurance number in Germany would look like
    /// "33 160894 W 098".
    /// </summary>
    public required string Number { get; init; }

}
