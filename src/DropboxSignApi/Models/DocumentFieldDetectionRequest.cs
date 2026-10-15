using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Core.Validation;
using DropboxSignApi.Core.Validation.Attributes;
using DropboxSignApi.Models.AnyOf;

namespace DropboxSignApi.Models;

public record DocumentFieldDetectionRequest
{
    /// <summary>
    /// The PDF file to analyze.
    /// <para>
    /// This endpoint requires either <c>file</c> or <c>file_url</c>, but not both.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("file")]
    public BinaryContent? File { get; init; }

    /// <summary>
    /// The URL of the PDF file to analyze.
    /// <para>
    /// This endpoint requires either <c>file</c> or <c>file_url</c>, but not both.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("file_url")]
    [Format(FormatKind.Uri)]
    public string? FileUrl { get; init; }

    /// <summary>
    /// The field detection method to use. Set to <c>annotations</c> to detect PDF form annotations or <c>text_tags</c> to detect Dropbox Sign text tags.
    /// </summary>
    [JsonPropertyName("detection_mode")]
    public required DetectionMode DetectionMode { get; init; }

    /// <summary>
    /// The zero-based page indexes to analyze. Accepts <c>all</c>, individual pages, inclusive ranges, or comma-separated combinations, such as <c>0-2,5,7-9</c>. Defaults to <c>all</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("page_range")]
    [RegularExpression("^(?:all|\\d+(?:-\\d+)?(?:,\\d+(?:-\\d+)?)*)$")]
    public string? PageRange { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
