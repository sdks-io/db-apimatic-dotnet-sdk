using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.Embedded;

/// <summary>
/// The inputs of the EmbeddedEditUrl operation.
/// </summary>
public sealed record EmbeddedEditUrlOperationRequest
{
    /// <summary>
    /// The id of the template to edit.
    /// </summary>
    public required string TemplateId { get; init; }

    public required EmbeddedEditUrlRequest Body { get; init; }
}
