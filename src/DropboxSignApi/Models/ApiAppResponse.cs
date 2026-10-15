using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// Contains information about an API App.
/// </summary>
public record ApiAppResponse
{
    /// <summary>
    /// The app's callback URL (for events)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("callback_url")]
    public string? CallbackUrl { get; init; }

    /// <summary>
    /// The app's client id
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// The time that the app was created
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public int? CreatedAt { get; init; }

    /// <summary>
    /// The domain name(s) associated with the app
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("domains")]
    public IReadOnlyList<string>? Domains { get; init; }

    /// <summary>
    /// The name of the app
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Boolean to indicate if the app has been approved
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_approved")]
    public bool? IsApproved { get; init; }

    /// <summary>
    /// An object describing the app's OAuth properties, or null if OAuth is not configured for the app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("oauth")]
    public ApiAppResponseOAuth? Oauth { get; init; }

    /// <summary>
    /// An object with options that override account settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public ApiAppResponseOptions? Options { get; init; }

    /// <summary>
    /// An object describing the app's owner
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("owner_account")]
    public ApiAppResponseOwnerAccount? OwnerAccount { get; init; }

    /// <summary>
    /// An object with options to customize the app's signer page
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("white_labeling_options")]
    public ApiAppResponseWhiteLabelingOptions? WhiteLabelingOptions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
