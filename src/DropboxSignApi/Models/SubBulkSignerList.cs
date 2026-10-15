using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record SubBulkSignerList
{
    /// <summary>
    /// An array of custom field values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_fields")]
    public IReadOnlyList<SubBulkSignerListCustomField>? CustomFields { get; init; }

    /// <summary>
    /// Add Signers to your Templated-based Signature Request. Allows the requester to specify editor options when a preparing a document.
    /// <para>
    /// Currently only templates with a single role are supported. All signers must have the same <c>role</c> value.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signers")]
    public IReadOnlyList<SubSignatureRequestTemplateSigner>? Signers { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
