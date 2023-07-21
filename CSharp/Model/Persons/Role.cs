namespace Fido.Model.Persons;

/// <summary>
/// The role of a person involved in the funeral case.
/// </summary>
public enum Role {

    /// <summary>
    /// This person is the deceased one.
    /// </summary>
    Deceased,

    /// <summary>
    /// The person, often from the family, who contacts and engages
    /// with the funeral home to make the necessary arrangements.
    /// </summary>
    ContactPerson,

    /// <summary>
    /// The person or institution who has to pay for the funeral.
    /// Often, this will be the same one as the ContactPerson.
    /// </summary>
    Payer,

}
