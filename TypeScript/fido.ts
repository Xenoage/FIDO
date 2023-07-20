/**
* A funeral case is a specific individual case in which a funeral
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
	/**
	* The same funeral case may have different IDs in the
	*             used software components. In this data structure, the
	*             ID of each involved software is stored. This allows each
	*             application involved in the funeral process to identify
	*             the funeral case in its own database when it comes back
	*             from another software. Each software may add its own ID here,
	*             but should never change the ID of other programs.
	*/
	Identification?: Identification[];
	/** The list of all persons, including the deceased. */
	Persons?: Person[];
	/**
	* The list of attached files,
	*             e.g. documents, photos or cards.
	*/
	Files?: any[];
}
/** Funeral case ID within a specific software program. */
export interface Identification
{
	/** Name of the software, e.g. "Funeral App Pro". */
	Software: string;
	/**
	* ID of the funeral case in this software. The format
	*             is specific to this software, and could be a number or
	*             any string, e.g. "00356", "SF-2023-0188",
	*             "Mustermann, Max, 2023-07-06" or a UUID.
	*/
	Id: string;
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
	*             Often, this will be the same one as the ContactPerson.
	*/
	Payer = "Payer"
}
/** Different ways to refer to file content. */
export enum FileType {
	/**
	* The file content is directly embedded in Base64 encoding
	*             (see https://datatracker.ietf.org/doc/html/rfc4648)
	*             into the File.Data property.
	*             This is the recommended way to share all files of a funeral case
	*             within a single JSON object and aims for maximum interoperability.
	*             However, the JSON object may become quite large.
	*             For each embedded file, about 133% of its original size is required
	*             when storing the data in Base64 format.
	*/
	Base64 = "Base64",
	/**
	* The file content can be found at the URL given in the File.Data property,
	*             e.g. https://storage.funeralapp.com/sf-0001/card.pdf?token=somesecretkey".
	*             This is the recommended way when the JSON file should be kept small and
	*             when the other software programs using this file are expected to be
	*             connected to the internet. However, there is overhead to upload the file content
	*             to some server and make it available, if required also protected from public
	*             access in some way, like a token as in the example above.
	*             Alternatively, but for local communication only, a local webserver could
	*             be spawned which serves the file at the given localhost URL.
	*             For maximum interoperability, prefer embedding the file content using the
	*             Base64 file type.
	*/
	Url = "Url",
	/**
	* The file content can be found on the local computer at the
	*             absolute path given in the File.Data property,
	*             e.g. "C:\Funeral Cases\SF-0001\Condolence Card.docx" on Windows
	*             or "/Users/Max/Funeral Cases/SF-0001/Condolence Card.docx" on Mac OS X
	*             or "/home/Max/Funeral Cases/SF-0001/Condolence Card.docx" on Linux.
	*             This file type should only be used within a local communication between
	*             programs on the same machine.
	*             For maximum interoperability, prefer embedding the file content using the
	*             Base64 file type.
	*/
	LocalFile = "LocalFile"
}