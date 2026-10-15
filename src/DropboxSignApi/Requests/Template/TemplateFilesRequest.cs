using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Requests.Template;

/// <summary>
/// The inputs of the TemplateFiles operation.
/// </summary>
public sealed record TemplateFilesRequest
{
    /// <summary>
    /// The id of the template files to retrieve.
    /// </summary>
    public required string TemplateId { get; init; }

    /// <summary>
    /// Set to <c>pdf</c> for a single merged document or <c>zip</c> for a collection of individual documents.
    /// </summary>
    public FileType? FileType { get; init; }
}
