using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Models;

/// <summary>
/// This allows the requester to specify field options for a signature request.
/// </summary>
public record SubFieldOptions
{
    /// <summary>
    /// Allows requester to specify the date format (see list of allowed <see href="/api/reference/constants/#date-formats">formats</see>)
    /// <para>
    /// <b>NOTE:</b> Only available for Premium and higher.
    /// </para>
    /// </summary>
    [JsonPropertyName("date_format")]
    public required DateFormat DateFormat { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
