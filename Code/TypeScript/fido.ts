/**
* In German: Bestattungsfall.
*             
*             A funeral case is specific individual case in which a funeral
*             is conducted by a funeral home. The term encompasses the entire process
*             of organizing and carrying out a funeral, including the formalities,
*             coordination with relatives, preparation of the deceased,
*             funeral ceremony, and burial.
*             
*             This is the basic data structure containing the personal data of the
*             deceased and other involved persons, appointments and documents.
*/
export interface FuneralCase
{
	/** The list of all persons, including the deceased. */
	Persons: Person[];
}
/**
* Information about a person.
*             Use only the fields which make sense in the context of the person.
*/
export interface Person
{
	/** Gender of the person. */
	Gender?: Gender;
	/**
	* Academic or professional title,
	*             like "Prof. Dr." as a German example.
	*/
	Title?: string;
	/**
	* Forename(s) of the person.
	*             In case of multiple forenames, separate by spaces.
	*/
	FirstName?: string;
	/**
	* In German naming conventions, it is common for individuals to have
	*             multiple given names, and the preferred name ("Rufname") refers to the
	*             name by which a person is primarily addressed or known in everyday life.
	*             It is the preferred or familiar name used by family, friends, and colleagues,
	*             as distinguished from the individual's other given names.
	*/
	PreferredName?: string;
	/** Surname of the Person. */
	LastName?: string;
	/** Birthdate of the person. */
	DateOfBirth?: string;
	/** Location, most often the city, where the person was born. */
	PlaceOfBirth?: string;
	/**
	* Nationality of the person. Use a ISO 3166-1 alpha-2 code,
	*             like "DE" for Germany. See https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2"
	*/
	Citizenship?: string;
	/**
	* Relationship of this person to the deceased (exactly one),
	*             or "Deceased" if this is the deceased person.
	*/
	Relationship: Relationship;
	/**
	* List of roles of this person in the funeral case.
	*             Not each involved person needs to have a role, but some
	*             persons may have multiple (e.g. both contact person and payer).
	*/
	Roles?: Role[];
}
/** List of genders. */
export enum Gender {
	Male = "Male",
	Female = "Female",
	Other = "Other"
}
/** Relationship of a person to the deceased. */
export enum Relationship {
	/** This person is the deceased one. */
	Deceased = "Deceased",
	/** Parent: Mother or father of the person. */
	Parent = "Parent",
	/** Child: Son or daughter of the person. */
	Child = "Child",
	/** Sibling: Brother or sister of the person. */
	Sibling = "Sibling",
	/** Spouse: Husband or wife, or life partner of the person. */
	Spouse = "Spouse",
	/** Grandparent: Grandfather or grandmother of the person. */
	Grandparent = "Grandparent",
	/** Grandchild: Grandson or granddaughter of the person. */
	Grandchild = "Grandchild",
	/** Aunt/Uncle: Sibling of a parent of the person. */
	AuntOrUncle = "AuntOrUncle",
	/** Niece/Nephew: Child of a sibling of the person. */
	NieceOrNephew = "NieceOrNephew",
	/** Cousin: Child of an aunt or uncle of the person. */
	Cousin = "Cousin",
	/** Other relationship, like friend, neighbor or colleague. */
	Other = "Other"
}
/** The role of a person involved in the funeral case. */
export enum Role {
	/**
	* The person, often from the family, who contacts and engages
	*             with the funeral home to make the necessary arrangements.
	*/
	ContactPerson = "ContactPerson",
	/**
	* The person or institution who has to pay for the funeral.
	*             Often, this will be the same one as the <see cref="F:Fido.Model.Persons.Role.ContactPerson" />.
	*/
	Payer = "Payer"
}
