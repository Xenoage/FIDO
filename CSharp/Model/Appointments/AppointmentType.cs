using System.ComponentModel;

namespace Fido.Model.Appointments;

/// <summary>
/// The purpose of the appointment.
/// </summary>
[Description("Appointments.AppointmentType")] // Required for JSON Schema documentation generator
public enum AppointmentType {

    /// <summary>
    /// Transporting a deceased person's body from one location to another.
    /// "Überführung" in German.
    /// </summary>
    Transportation,

    /// <summary>
    /// Incineration at a crematory.
    /// "Einäscherung" in German.
    /// </summary>
    Cremation,

    /// <summary>
    /// The ceremony to honor and remember the deceased.
    /// "Trauerfeier" in German.
    /// </summary>
    FuneralService,

    /// <summary>
    /// Placing the deceased's body in the ground or a tomb.
    /// "Beisetzung" in German.
    /// </summary>
    Burial,

    /// <summary>
    /// Visiting to express sympathy and support to the grieving family or friends.
    /// "Kondolenzbesuch" in German.
    /// </summary>
    CondolenceVisit

}