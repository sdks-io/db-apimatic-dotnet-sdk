using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record SubSignatureRequestGroupedSigners
{
    /// <summary>
    /// The name of the group.
    /// </summary>
    [JsonPropertyName("group")]
    public required string Group { get; init; }

    /// <summary>
    /// The order the group is required to sign in. Use this instead of Signer-level <c>order</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public int? Order { get; init; }

    /// <summary>
    /// Signers belonging to this Group.
    /// <para>
    /// <b>NOTE:</b> Only <c>name</c>, <c>email_address</c>, and <c>pin</c> are available to Grouped Signers. We will ignore all other properties, even though they are listed below.
    /// </para>
    /// </summary>
    [JsonPropertyName("signers")]
    public required IReadOnlyList<SubSignatureRequestSigner> Signers { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
