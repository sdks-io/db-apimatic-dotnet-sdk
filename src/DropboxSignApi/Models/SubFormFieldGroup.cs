using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record SubFormFieldGroup
{
    /// <summary>
    /// ID of group. Use this to reference a specific group from the <c>group</c> value in <c>form_fields_per_document</c>.
    /// </summary>
    [JsonPropertyName("group_id")]
    public required string GroupId { get; init; }

    /// <summary>
    /// Name of the group
    /// </summary>
    [JsonPropertyName("group_label")]
    public required string GroupLabel { get; init; }

    /// <summary>
    /// Examples: <c>require_0-1</c> <c>require_1</c> <c>require_1-ormore</c>
    /// <list type="bullet">
    ///   <item><description>Check out the list of <see href="/api/reference/constants/#checkbox-field-grouping">acceptable <c>requirement</c> checkbox type values</see>.</description></item>
    ///   <item><description>Check out the list of <see href="/api/reference/constants/#radio-field-grouping">acceptable <c>requirement</c> radio type fields</see>.</description></item>
    ///   <item><description>Radio groups require <b>at least</b> two fields per group.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("requirement")]
    public required string Requirement { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
