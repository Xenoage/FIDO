using System.ComponentModel;

namespace Fido.Model.Persons;

[Description("Information about a person. " +
    "Use only the fields which make sense in the context of the person.")]
public record Person {

    [Description("Gender of the person.")]
    public Gender? Gender { get; set; }

    [Description("Academic or professional title, " +
        "like \"Prof. Dr.\" as a German example.")]
    public string? Title { get; set; }

    [Description("Forename(s) of the person. " +
        "In case of multiple forenames, separate by spaces.")]
    public string? FirstName { get; init; }

    [Description("In German naming conventions, it is common for individuals to have " +
        "multiple given names, and the preferred name (\"Rufname\") refers to the " +
        "name by which a person is primarily addressed or known in everyday life. " +
        "It is the preferred or familiar name used by family, friends, and colleagues, " +
        "as distinguished from the individual's other given names.")]
    public string? PreferredName { get; init; }

    [Description("Surname of the Person.")]
    public string? LastName { get; init; }

    [Description("Birthdate of the person.")]
    public DateOnly? DateOfBirth { get; init; }

    [Description("Location, most often the city, where the person was born.")]
    public string? PlaceOfBirth { get; init; }

    [Description("Nationality of the person. Use a ISO 3166-1 alpha-2 code, " +
        "like \"DE\" for Germany. See https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2")]
    public string? Citizenship { get; init; }

    [Description("Relationship of this person to the deceased (exactly one), " +
        "or \"Deceased\" if this is the deceased person.")]
    public required Relationship Relationship { get; init; }

    [Description("List of roles of this person in the funeral case. " +
        "Not each involved person needs to have a role, but some " +
        "persons may have multiple (e.g. both contact person and payer).")]
    public List<Role>? Roles { get; init; }

}
