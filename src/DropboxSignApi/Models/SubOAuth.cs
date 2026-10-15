using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Models;

/// <summary>
/// OAuth related parameters.
/// </summary>
public record SubOAuth
{
    /// <summary>
    /// The callback URL to be used for OAuth flows. (Required if <c>oauth[scopes]</c> is provided)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("callback_url")]
    public string? CallbackUrl { get; init; }

    /// <summary>
    /// A list of <see href="/api/reference/tag/OAuth">OAuth scopes</see> to be granted to the app. (Required if <c>oauth[callback_url]</c> is provided).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scopes")]
    public IReadOnlyList<Scope>? Scopes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
