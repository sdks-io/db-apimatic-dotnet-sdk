using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Models;

/// <summary>
/// This class extends <c>SubFormFieldsPerDocumentBase</c>.
/// </summary>
public record SubFormFieldsPerDocumentHyperlinkProperties
{
    /// <summary>
    /// A hyperlink field. Use the <c>SubFormFieldsPerDocumentHyperlink</c> class.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "hyperlink";

    /// <summary>
    /// Link Text.
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; init; }

    /// <summary>
    /// Link URL.
    /// </summary>
    [JsonPropertyName("content_url")]
    public required string ContentUrl { get; init; }

    /// <summary>
    /// Font family for the field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("font_family")]
    public FontFamily? FontFamily { get; init; }

    /// <summary>
    /// The initial px font size for the field contents. Can be any integer value between <c>7</c> and <c>49</c>.
    /// <para>
    /// <b>NOTE:</b> Font size may be reduced during processing in order to fit the contents within the dimensions of the field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("font_size")]
    public int? FontSize { get; init; } = 12;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
