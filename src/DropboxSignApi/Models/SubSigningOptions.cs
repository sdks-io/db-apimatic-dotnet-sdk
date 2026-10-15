using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Models;

/// <summary>
/// This allows the requester to specify the types allowed for creating a signature and specify another signing options.
/// <para>
/// <b>NOTE:</b> If <c>signing_options</c> are not defined in the request, the allowed types will default to those specified in the account settings.
/// </para>
/// <para>
/// <b>NOTE:</b> If <c>force_advanced_signature_details</c> is set, allowed types has to be defined too.
/// </para>
/// </summary>
public record SubSigningOptions
{
    /// <summary>
    /// The default type shown (limited to the listed types)
    /// </summary>
    [JsonPropertyName("default_type")]
    public required DefaultType DefaultType { get; init; }

    /// <summary>
    /// Allows drawing the signature
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("draw")]
    public bool? Draw { get; init; } = false;

    /// <summary>
    /// Allows using a smartphone to email the signature
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public bool? Phone { get; init; } = false;

    /// <summary>
    /// Allows typing the signature
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public bool? Type { get; init; } = false;

    /// <summary>
    /// Allows uploading the signature
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("upload")]
    public bool? Upload { get; init; } = false;

    /// <summary>
    /// Turning on advanced signature details for the signature request
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("force_advanced_signature_details")]
    public bool? ForceAdvancedSignatureDetails { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
