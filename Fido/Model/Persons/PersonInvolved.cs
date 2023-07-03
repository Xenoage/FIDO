namespace Fido.Model.Persons;

/// <summary>
/// A person involved in the funeral case,
/// e.g. a relative of the deceased.
/// </summary>
public record PersonInvolved : Person {

    /// <summary>
    /// Relationship of this person to the deceased.
    /// Use one of the 
    /// </summary>
    public string? Relationship { get; init; }

}
