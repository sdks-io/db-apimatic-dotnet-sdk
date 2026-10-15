using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Models;

public record SubFormFieldRuleTrigger
{
    /// <summary>
    /// Must reference the <c>api_id</c> of an existing field defined within <c>form_fields_per_document</c>. Trigger and action fields and groups must belong to the same signer.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Different field types allow different <c>operator</c> values:
    /// - Field type of <b>text</b>:
    ///   - <b>is</b>: exact match
    ///   - <b>not</b>: not exact match
    ///   - <b>match</b>: regular expression, without /. Example:
    ///     - OK <c>[a-zA-Z0-9]</c>
    ///     - Not OK <c>/[a-zA-Z0-9]/</c>
    /// - Field type of <b>dropdown</b>:
    ///   - <b>is</b>: exact match, single value
    ///   - <b>not</b>: not exact match, single value
    ///   - <b>any</b>: exact match, array of values.
    ///   - <b>none</b>: not exact match, array of values.
    /// - Field type of <b>checkbox</b>:
    ///   - <b>is</b>: exact match, single value
    ///   - <b>not</b>: not exact match, single value
    /// - Field type of <b>radio</b>:
    ///   - <b>is</b>: exact match, single value
    ///   - <b>not</b>: not exact match, single value
    /// </summary>
    [JsonPropertyName("operator")]
    public required Operator Operator { get; init; }

    /// <summary>
    /// <b>value</b> or <b>values</b> is required, but not both.
    /// <para>
    /// The value to match against <b>operator</b>.
    /// </para>
    /// <list type="bullet">
    ///   <item><description>When <b>operator</b> is one of the following, <b>value</b> must be <c>String</c>:
    ///     <list type="bullet">
    ///       <item><description><c>is</c></description></item>
    ///       <item><description><c>not</c></description></item>
    ///       <item><description><c>match</c></description></item>
    ///     </list>
    ///   </description></item>
    /// </list>
    /// <para>
    /// Otherwise,
    /// - <b>checkbox</b>: When <b>type</b> of trigger is <b>checkbox</b>, <b>value</b> must be <c>0</c> or <c>1</c>
    /// - <b>radio</b>: When <b>type</b> of trigger is <b>radio</b>, <b>value</b> must be <c>1</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public string? Value { get; init; }

    /// <summary>
    /// <b>values</b> or <b>value</b> is required, but not both.
    /// <para>
    /// The values to match against <b>operator</b> when it is one of the following:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>any</c></description></item>
    ///   <item><description><c>none</c></description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("values")]
    public IReadOnlyList<string>? Values { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
