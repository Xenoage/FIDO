using Fido.Model.Appointments;
using Fido.Model.Documents;
using Fido.Model.Files;
using Fido.Model.Persons;
using Fido.Model.Stakeholders;
using System.Collections.Generic;
using System.ComponentModel;

namespace Fido.Model;

/// <summary>
/// A funeral case is a specific individual case in which a funeral
/// is conducted by a funeral home. The term encompasses the entire process
/// of organizing and carrying out a funeral, including the formalities,
/// coordination with relatives, preparation of the deceased,
/// funeral ceremony, and burial.
/// 
/// This is the basic data structure containing the personal data of the
/// deceased and other involved persons, appointments and documents.
/// </summary>
[Description("FuneralCase")] // Required for JSON Schema documentation generator
public record FuneralCase {

    /// <summary>
    /// Must contain "FIDO" to mark this object as a FIDO object.
    /// </summary>
    public string FormatName { get; init; } = "FIDO";

    /// <summary>
    /// Version number of the FIDO format used in this object.
    /// The current version number is "0.0.2".
    /// </summary>
    public string FormatVersion { get; init; } = "0.0.2";

    /// <summary>
    /// The same funeral case may have different IDs in the
    /// used software components. In this data structure, the
    /// ID of each involved software is stored. This allows each
    /// application involved in the funeral process to identify
    /// the funeral case in its own database when it comes back
    /// from another software. Each software may add its own ID here,
    /// but should never change the ID of other programs.
    /// </summary>
    public List<Stakeholder>? Stakeholders { get; init; }

    /// <summary>
    /// The list of all persons, including the deceased.
    /// </summary>
    public List<Person>? Persons { get; init; }

    /// <summary>
    /// The list of all appointments in this death case.
    /// </summary>
    public List<Appointment>? Appointments { get; init; }

    /// <summary>
    /// The list of documents,
    /// e.g. a death notification or a memorial card.
    /// </summary>
    public List<Document>? Documents { get; init; }

    /// <summary>
    /// Information about the funeral home taking care of the funeral process.
    /// </summary>
    public FuneralHome? FuneralHome { get; init; }

    /// <summary>
    /// The list of attached files, e.g. documents, photos or cards.
    /// To optimize performance, consider placing this property as the last one
    /// in the JSON object when storing large raw data.
    /// This strategy allows the reading software to access important information
    /// quickly or abort processing if necessary.
    /// </summary>
    public List<File>? Files { get; init; }

}