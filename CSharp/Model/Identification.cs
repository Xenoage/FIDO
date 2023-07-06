using System.ComponentModel;

namespace Fido.Model;

/// <summary>
/// Funeral case ID within a specific software program.
/// </summary>
[Description("Identification")] // Required for JSON Schema documentation generator
public record Identification {

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

}