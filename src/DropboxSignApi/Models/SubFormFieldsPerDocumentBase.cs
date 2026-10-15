using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// The fields that should appear on the document, expressed as an array of objects. (For more details you can read about it here: <see href="/docs/openapi/form-fields-per-document">Using Form Fields per Document</see>.)
/// <para>
/// <b>NOTE:</b> Fields like <b>text</b>, <b>dropdown</b>, <b>checkbox</b>, <b>radio</b>, and <b>hyperlink</b> have additional required and optional parameters. Check out the list of <see href="/api/reference/constants/#form-fields-per-document">additional parameters</see> for these field types.
/// </para>
/// <list type="bullet">
///   <item><description>Text Field use <c>SubFormFieldsPerDocumentText</c></description></item>
///   <item><description>Dropdown Field use <c>SubFormFieldsPerDocumentDropdown</c></description></item>
///   <item><description>Hyperlink Field use <c>SubFormFieldsPerDocumentHyperlink</c></description></item>
///   <item><description>Checkbox Field use <c>SubFormFieldsPerDocumentCheckbox</c></description></item>
///   <item><description>Radio Field use <c>SubFormFieldsPerDocumentRadio</c></description></item>
///   <item><description>Signature Field use <c>SubFormFieldsPerDocumentSignature</c></description></item>
///   <item><description>Date Signed Field use <c>SubFormFieldsPerDocumentDateSigned</c></description></item>
///   <item><description>Initials Field use <c>SubFormFieldsPerDocumentInitials</c></description></item>
///   <item><description>Text Merge Field use <c>SubFormFieldsPerDocumentTextMerge</c></description></item>
///   <item><description>Checkbox Merge Field use <c>SubFormFieldsPerDocumentCheckboxMerge</c></description></item>
/// </list>
/// </summary>
public record SubFormFieldsPerDocumentBase
{
    /// <summary>
    /// Represents the integer index of the <c>file</c> or <c>file_url</c> document the field should be attached to.
    /// </summary>
    [JsonPropertyName("document_index")]
    public required int DocumentIndex { get; init; }

    /// <summary>
    /// An identifier for the field that is unique across all documents in the request.
    /// </summary>
    [JsonPropertyName("api_id")]
    public required string ApiId { get; init; }

    /// <summary>
    /// Size of the field in pixels.
    /// </summary>
    [JsonPropertyName("height")]
    public required int Height { get; init; }

    /// <summary>
    /// Display name for the field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Page in the document where the field should be placed (requires documents be PDF files).
    /// <list type="bullet">
    ///   <item><description>When the page number parameter is supplied, the API will use the new coordinate system.</description></item>
    ///   <item><description>Check out the differences between both <see href="https://faq.hellosign.com/hc/en-us/articles/217115577">coordinate systems</see> and how to use them.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("page")]
    public int? Page { get; init; }

    /// <summary>
    /// Whether this field is required.
    /// </summary>
    [JsonPropertyName("required")]
    public required bool Required { get; init; }

    /// <summary>
    /// Signer index identified by the offset in the signers parameter (0-based indexing), indicating which signer should fill out the field.
    /// <para>
    /// <b>NOTE:</b> To set the value of the field as the preparer you must set this to <c>me_now</c>
    /// </para>
    /// <para>
    /// <b>NOTE:</b> If type is <c>text-merge</c> or <c>checkbox-merge</c>, you must set this to sender in order to use pre-filled data.
    /// </para>
    /// </summary>
    [JsonPropertyName("signer")]
    public required string Signer { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// Size of the field in pixels.
    /// </summary>
    [JsonPropertyName("width")]
    public required int Width { get; init; }

    /// <summary>
    /// Location coordinates of the field in pixels.
    /// </summary>
    [JsonPropertyName("x")]
    public required int X { get; init; }

    /// <summary>
    /// Location coordinates of the field in pixels.
    /// </summary>
    [JsonPropertyName("y")]
    public required int Y { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
