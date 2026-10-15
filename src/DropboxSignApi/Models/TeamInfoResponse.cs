using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record TeamInfoResponse
{
    /// <summary>
    /// The id of a team
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_id")]
    public string? TeamId { get; init; }

    /// <summary>
    /// Information about the parent team if a team has one, set to <c>null</c> otherwise.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_parent")]
    public TeamParentResponse? TeamParent { get; init; }

    /// <summary>
    /// The name of a team
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Number of members within a team
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_members")]
    public int? NumMembers { get; init; }

    /// <summary>
    /// Number of sub teams within a team
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_sub_teams")]
    public int? NumSubTeams { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
