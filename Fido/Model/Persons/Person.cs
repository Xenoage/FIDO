namespace Fido.Model.Persons;

/// <summary>
/// General information about a person.
/// </summary>
public record Person {

    /// <summary>
    /// Gender of the person.
    /// </summary>
    public Gender? Gender { get; set; }

    /// <summary>
    /// Academic or professional title,
    /// like "Prof. Dr." as a German example.
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Forename(s) of the person.
    /// In case of multiple forenames, separate by spaces.
    /// </summary>
    public string? FirstName { get; init; }

    /// <summary>
    /// In German naming conventions, it is common for individuals to have
    /// multiple given names, and the preferred name ("Rufname") refers to the
    /// name by which a person is primarily addressed or known in everyday life.
    /// It is the preferred or familiar name used by family, friends, and colleagues,
    /// as distinguished from the individual's other given names.
    /// </summary>
    public string? PreferredName { get; init; }

    /// <summary>
    /// Surname of the Person.
    /// </summary>
    public string? LastName { get; init; }

    /// <summary>
    /// Birthdate of the person.
    /// </summary>
    public DateOnly? DateOfBirth { get; init; }

    /// <summary>
    /// Location, most often the city, where the person was born.
    /// </summary>
    public string? PlaceOfBirth { get; init; }

    /// <summary>
    /// Nationality of the person. Use a ISO 3166-1 alpha-2 code,
    /// like "DE" for Germany. See https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2
    /// </summary>
    public string? Citizenship { get; init; }

}