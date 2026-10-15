using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Models;

/// <summary>
/// This class extends <c>SubFormFieldsPerDocumentBase</c>.
/// </summary>
public record SubFormFieldsPerDocumentTextProperties
{
    /// <summary>
    /// A text input field. Use the <c>SubFormFieldsPerDocumentText</c> class.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "text";

    /// <summary>
    /// Placeholder value for text field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("placeholder")]
    public string? Placeholder { get; init; }

    /// <summary>
    /// Auto fill type for populating fields automatically. Check out the list of <see href="/api/reference/constants/#auto-fill-types">auto fill types</see> to learn more about the possible values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auto_fill_type")]
    public string? AutoFillType { get; init; }

    /// <summary>
    /// Link two or more text fields. Enter data into one linked text field, which automatically fill all other linked text fields.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link_id")]
    public string? LinkId { get; init; }

    /// <summary>
    /// Masks entered data. For more information see <see href="https://faq.hellosign.com/hc/en-us/articles/360040742811-Masking-sensitive-information">Masking sensitive information</see>. <c>true</c> for masking the data in a text field, otherwise <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("masked")]
    public bool? Masked { get; init; }

    /// <summary>
    /// Each text field may contain a <c>validation_type</c> parameter. Check out the list of <see href="https://faq.hellosign.com/hc/en-us/articles/217115577">validation types</see> to learn more about the possible values.
    /// <para>
    /// <b>NOTE:</b> When using <c>custom_regex</c> you are required to pass a second parameter <c>validation_custom_regex</c> and you can optionally provide <c>validation_custom_regex_format_label</c> for the error message the user will see in case of an invalid value.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("validation_type")]
    public ValidationType? ValidationType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("validation_custom_regex")]
    public string? ValidationCustomRegex { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("validation_custom_regex_format_label")]
    public string? ValidationCustomRegexFormatLabel { get; init; }

    /// <summary>
    /// Content of a <c>me_now</c> text field
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
