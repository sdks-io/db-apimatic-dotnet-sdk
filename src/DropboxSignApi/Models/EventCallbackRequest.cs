using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record EventCallbackRequest
{
    /// <summary>
    /// Basic information about the event that occurred.
    /// </summary>
    [JsonPropertyName("event")]
    public required EventCallbackRequestEvent Event { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account")]
    public AccountResponse? Account { get; init; }

    /// <summary>
    /// Contains information about a signature request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signature_request")]
    public SignatureRequestResponse? SignatureRequest { get; init; }

    /// <summary>
    /// Contains information about the templates you and your team have created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("template")]
    public TemplateResponse? Template { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
