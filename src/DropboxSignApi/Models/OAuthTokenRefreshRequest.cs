using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record OAuthTokenRefreshRequest
{
    /// <summary>
    /// When refreshing an existing token use <c>refresh_token</c>.
    /// </summary>
    [JsonPropertyName("grant_type")]
    public string GrantType { get; init; } = "refresh_token";

    /// <summary>
    /// The token provided when you got the expired access token.
    /// </summary>
    [JsonPropertyName("refresh_token")]
    public required string RefreshToken { get; init; }

    /// <summary>
    /// The client ID for your API app. Required for new API apps. To enhance security, we recommend making it required for existing apps in your app settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// The client secret for your API app. Required for new API apps. To enhance security, we recommend making it required for existing apps in your app settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_secret")]
    public string? ClientSecret { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
