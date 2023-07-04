using System.ComponentModel;

namespace Fido.Model.Persons;

[Description("Relationship of a person to another person.")]
public enum Relationship {

    [Description("This person is the deceased one.")]
    Deceased,

    /// <summary>
    /// Parent: Mother or father of the person.
    /// </summary>
    Parent,

    /// <summary>
    /// Child: Son or daughter of the person.
    /// </summary>
    Child,

    /// <summary>
    /// Sibling: Brother or sister of the person.
    /// </summary>
    Sibling,

    /// <summary>
    /// Spouse: Husband or wife, or life partner of the person.
    /// </summary>
    Spouse,

    /// <summary>
    /// Grandparent: Grandfather or grandmother of the person.
    /// </summary>
    Grandparent,

    /// <summary>
    /// Grandchild: Grandson or granddaughter of the person.
    /// </summary>
    Grandchild,

    /// <summary>
    /// Aunt/Uncle: Sibling of a parent of the person.
    /// </summary>
    AuntOrUncle,

    /// <summary>
    /// Niece/Nephew: Child of a sibling of the person.
    /// </summary>
    NieceOrNephew,

    /// <summary>
    /// Cousin: Child of an aunt or uncle of the person.
    /// </summary>
    Cousin,

    /// <summary>
    /// Other relationship, like friend, neighbor or colleague.
    /// </summary>
    Other

}
