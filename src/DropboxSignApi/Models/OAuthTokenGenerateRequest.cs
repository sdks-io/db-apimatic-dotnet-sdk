using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record OAuthTokenGenerateRequest
{
    /// <summary>
    /// The client id of the app requesting authorization.
    /// </summary>
    [JsonPropertyName("client_id")]
    public required string ClientId { get; init; }

    /// <summary>
    /// The secret token of your app.
    /// </summary>
    [JsonPropertyName("client_secret")]
    public required string ClientSecret { get; init; }

    /// <summary>
    /// The code passed to your callback when the user granted access.
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    /// <summary>
    /// When generating a new token use <c>authorization_code</c>.
    /// </summary>
    [JsonPropertyName("grant_type")]
    public string GrantType { get; init; } = "authorization_code";

    /// <summary>
    /// Same as the state you specified earlier.
    /// </summary>
    [JsonPropertyName("state")]
    public required string State { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
