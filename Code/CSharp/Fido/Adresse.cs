namespace Fido;

/// <summary>
/// Anschrift z.B. einer Person.
/// </summary>
public record Adresse {
    
    /// <summary>
    /// Straße (ohne Hausnummer).
    /// </summary>
    public string? Straße { get; init; }

    /// <summary>
    /// Hausnummer.
    /// String-Datentyp, da auch komplexere Hausnummern wie "1a" möglich sind.
    /// </summary>
    public string? Hausnummer { get; init; }    

}