using System;
using System.ComponentModel;
using Fido.Model.Shared;

namespace Fido.Model.Appointments;

/// <summary>
/// A document related to a funeral case.
/// Some examples are a death notification ("Sterbefallanzeige" in German),
/// an order confirmation, a bill or a memorial card ("Trauerkarte" in German).
/// A document consists of a name and a file, optionally including preview images.
/// </summary>
[Description("Appointments.Appointment")] // Required for JSON Schema documentation generator
public record Appointment {

    /// <summary>
    /// Title of the appointment,
    /// e.g. "Trauergottesdienst" (German for funeral service).
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Purpose of the appointment. If none of the available options applies,
    /// omit this property and just use a descriptive "Name".
    /// </summary>
    public AppointmentType? Type { get; init; }

    /// <summary>
    /// Date and time, when the appointment begins.
    /// </summary>
    public DateTime? StartDate { get; init; }

    /// <summary>
    /// Date and time, when the appointment ends. Optional.
    /// </summary>
    public DateTime? EndDate { get; init; }

    /// <summary>
    /// Description of the location, e.g. "St. Peter's Church".
    /// </summary>
    public string? Location { get; init; }

    /// <summary>
    /// Formal address of the appointment.
    /// </summary>
    public Address? Address { get; init; }

}