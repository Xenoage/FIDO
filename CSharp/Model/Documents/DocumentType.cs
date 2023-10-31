using System.ComponentModel;

namespace Fido.Model.Documents;

/// <summary>
/// The purpose of the document.
/// </summary>
[Description("Documents.DocumentType")] // Required for JSON Schema documentation generator
public enum DocumentType {

    /// <summary>
    /// A portrait photo of the deceased.
    /// </summary>
    PortraitPhoto,

    /// <summary>
    /// Additional images, whether they are photographs, paintings, or drawings,
    /// related to the funeral. They can be used, for example, to create memorial cards.
    /// Do not use this type for photocopies of official documents.
    /// </summary>
    Image

}