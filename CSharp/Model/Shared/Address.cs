using System.Collections.Generic;
using System.ComponentModel;

namespace Fido.Model.Shared;

/// <summary>
/// Address and contact information.
/// </summary>
[Description("Shared.Address")] // Required for JSON Schema documentation generator
public record Address {

    /// <summary>
    /// Street name, like "Main Street".
    /// </summary>
    public string? Street { get; init; }

    /// <summary>
    /// House number within the street, like "4" or "13b".
    /// </summary>
    public string? HouseNumber { get; init; }

    /// <summary>
    /// Zip code, like "86529" in Germany.
    /// </summary>
    public string? ZipCode { get; init; }

    /// <summary>
    /// Name of the city, like "Schrobenhausen".
    /// </summary>
    public string? City { get; init; }

    /// <summary>
    /// Country code. Use a ISO 3166-1 alpha-2 code,
    /// like "DE" for Germany. See https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2".
    /// This property can be omitted when the context is clear, e.g. when the
    /// address is in the same country as the whole funeral case.
    /// </summary>
    public string? Country { get; init; }

    /// <summary>
    /// List of phone numbers. For example, both a
    /// home phone number and a mobile phone number may be given.
    /// </summary>
    public List<string>? PhoneNumbers { get; init; }

    /// <summary>
    /// E-Mail address of the contact, e.g. "info@fidoformat.org".
    /// </summary>
    public string? EMailAddress { get; init; }

}
