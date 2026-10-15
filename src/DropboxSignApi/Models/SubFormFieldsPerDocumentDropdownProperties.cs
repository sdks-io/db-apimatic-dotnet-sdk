using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Models;

/// <summary>
/// This class extends <c>SubFormFieldsPerDocumentBase</c>.
/// </summary>
public record SubFormFieldsPerDocumentDropdownProperties
{
    /// <summary>
    /// An input field for dropdowns. Use the <c>SubFormFieldsPerDocumentDropdown</c> class.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "dropdown";

    /// <summary>
    /// Array of string values representing dropdown values.
    /// </summary>
    [JsonPropertyName("options")]
    [MinLength(1)]
    public required IReadOnlyList<string> Options { get; init; }

    /// <summary>
    /// Selected value in <c>options</c> array. Value must exist in array.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("content")]
    public string? Content { get; init; }

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
