using System.Collections.Generic;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record FaxResponse
{
    /// <summary>
    /// Fax ID
    /// </summary>
    [JsonPropertyName("fax_id")]
    public required string FaxId { get; init; }

    /// <summary>
    /// Fax Title
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; init; }

    /// <summary>
    /// Fax Original Title
    /// </summary>
    [JsonPropertyName("original_title")]
    public required string OriginalTitle { get; init; }

    /// <summary>
    /// Fax Subject
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subject")]
    public string? Subject { get; init; }

    /// <summary>
    /// Fax Message
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    /// <summary>
    /// Fax Metadata
    /// </summary>
    [JsonPropertyName("metadata")]
    public required IReadOnlyDictionary<string, object> Metadata { get; init; }

    /// <summary>
    /// Fax Created At Timestamp
    /// </summary>
    [JsonPropertyName("created_at")]
    public required int CreatedAt { get; init; }

    /// <summary>
    /// Fax Sender Email
    /// </summary>
    [JsonPropertyName("sender")]
    public required string Sender { get; init; }

    /// <summary>
    /// Fax Files URL
    /// </summary>
    [JsonPropertyName("files_url")]
    public required string FilesUrl { get; init; }

    /// <summary>
    /// The path where the completed document can be downloaded
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("final_copy_uri")]
    public string? FinalCopyUri { get; init; }

    /// <summary>
    /// Fax Transmissions List
    /// </summary>
    [JsonPropertyName("transmissions")]
    public required IReadOnlyList<FaxResponseTransmission> Transmissions { get; init; }

    /// <summary>
    /// Whether this is a test fax. Test faxes are not delivered to the recipient. Defaults to <c>false</c>.
    /// </summary>
    [JsonPropertyName("test_mode")]
    public bool TestMode { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
