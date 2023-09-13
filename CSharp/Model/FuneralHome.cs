using System.ComponentModel;
using Fido.Model.Shared;

namespace Fido.Model;

/// <summary>
/// Information about the funeral home taking care of the funeral process.
/// </summary>
[Description("FuneralHome")] // Required for JSON Schema documentation generator
public record FuneralHome {

    /// <summary>
    /// Title of the funeral home.
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// Address of the funeral home.
    /// </summary>
    public Address? Address { get; set; }

}
