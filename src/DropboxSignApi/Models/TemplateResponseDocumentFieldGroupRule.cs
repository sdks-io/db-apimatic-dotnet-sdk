using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

/// <summary>
/// The rule used to validate checkboxes in the form field group. See <see href="/api/reference/constants/#checkbox-field-grouping">checkbox field grouping</see>.
/// </summary>
public record TemplateResponseDocumentFieldGroupRule
{
    /// <summary>
    /// Examples: <c>require_0-1</c> <c>require_1</c> <c>require_1-ormore</c>
    /// <list type="bullet">
    ///   <item><description>Check out the list of <see href="/api/reference/constants/#checkbox-field-grouping">acceptable <c>requirement</c> checkbox type values</see>.</description></item>
    ///   <item><description>Check out the list of <see href="/api/reference/constants/#radio-field-grouping">acceptable <c>requirement</c> radio type fields</see>.</description></item>
    ///   <item><description>Radio groups require <b>at least</b> two fields per group.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requirement")]
    public string? Requirement { get; init; }

    /// <summary>
    /// Name of the group
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groupLabel")]
    public string? GroupLabel { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
