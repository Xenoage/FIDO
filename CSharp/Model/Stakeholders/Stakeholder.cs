using System.ComponentModel;

namespace Fido.Model.Stakeholders;

/// <summary>
/// Record for each stakeholder within the funeral process.
/// Usually, these are the involved software programs,
/// identified by their name and unique funeral case ID within that program.
/// </summary>
[Description("Stakeholders.Stakeholder")] // Required for JSON Schema documentation generator
public record Stakeholder {

    /// <summary>
    /// Name of the software, e.g. "Funeral App Pro".
    /// </summary>
    public required string Software { get; init; }

    /// <summary>
    /// ID of the funeral case in this software. The format
    /// is specific to this software, and could be a number or
    /// any string, e.g. "00356", "SF-2023-0188",
    /// "Mustermann, Max, 2023-07-06" or a UUID.
    /// </summary>
    public required string Id { get; init; }
    
    /// <summary>
    /// ID of the user in this software, which created or modified
    /// this funeral case. Optional.
    /// </summary>
    public string? UserId { get; init; }

    /// <summary>
    /// URL for the API of the software.
    /// This is implementation-specific, but can be used to signify
    /// where additional data can be queried from or reported to.
    /// </summary>
    public string? ApiUrl { get; init; }

}