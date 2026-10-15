using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Requests.Template;

/// <summary>
/// The inputs of the TemplateUpdateFiles operation.
/// </summary>
public sealed record TemplateUpdateFilesOperationRequest
{
    /// <summary>
    /// The ID of the template whose files to update.
    /// </summary>
    public required string TemplateId { get; init; }

    /// <summary>
    /// Client id of the app you're using to update this template.
    /// </summary>
    public string? ClientId { get; init; }

    /// <summary>
    /// Use <c>files[]</c> to indicate the uploaded file(s) to use for the template.
    /// <para>
    /// This endpoint requires either <b>files</b> or <b>file_urls[]</b>, but not both.
    /// </para>
    /// </summary>
    public BinaryContent? Files { get; init; }

    /// <summary>
    /// Use <c>file_urls[]</c> to have Dropbox Sign download the file(s) to use for the template.
    /// <para>
    /// This endpoint requires either <b>files</b> or <b>file_urls[]</b>, but not both.
    /// </para>
    /// </summary>
    public IReadOnlyList<string>? FileUrls { get; init; }

    /// <summary>
    /// The new default template email message.
    /// </summary>
    [MaxLength(5000)]
    public string? Message { get; init; }

    /// <summary>
    /// The new default template email subject.
    /// </summary>
    [MaxLength(100)]
    public string? Subject { get; init; }

    /// <summary>
    /// Whether this is a test, the signature request created from this draft will not be legally binding if set to <c>true</c>. Defaults to <c>false</c>.
    /// </summary>
    public bool TestMode { get; init; } = false;
}
