using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record SubTemplateRole
{
    /// <summary>
    /// The role name of the signer that will be displayed when the template is used to create a signature request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The order in which this signer role is required to sign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public int? Order { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
