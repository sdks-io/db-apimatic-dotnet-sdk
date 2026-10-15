using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Models;

public record SubFormFieldRuleAction
{
    /// <summary>
    /// <b>field_id</b> or <b>group_id</b> is required, but not both.
    /// <para>
    /// Must reference the <c>api_id</c> of an existing field defined within <c>form_fields_per_document</c>.
    /// </para>
    /// <para>
    /// Cannot use with <c>group_id</c>. Trigger and action fields must belong to the same signer.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field_id")]
    public string? FieldId { get; init; }

    /// <summary>
    /// <b>group_id</b> or <b>field_id</b> is required, but not both.
    /// <para>
    /// Must reference the ID of an existing group defined within <c>form_field_groups</c>.
    /// </para>
    /// <para>
    /// Cannot use with <c>field_id</c>. Trigger and action fields and groups must belong to the same signer.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("group_id")]
    public string? GroupId { get; init; }

    /// <summary>
    /// <c>true</c> to hide the target field when rule is satisfied, otherwise <c>false</c>.
    /// </summary>
    [JsonPropertyName("hidden")]
    public required bool Hidden { get; init; }

    [JsonPropertyName("type")]
    public required Type1 Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
