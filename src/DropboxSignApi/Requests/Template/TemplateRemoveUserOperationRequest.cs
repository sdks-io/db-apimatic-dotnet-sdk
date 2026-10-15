using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.Template;

/// <summary>
/// The inputs of the TemplateRemoveUser operation.
/// </summary>
public sealed record TemplateRemoveUserOperationRequest
{
    /// <summary>
    /// The id of the Template to remove the Account's access to.
    /// </summary>
    public required string TemplateId { get; init; }

    public required TemplateRemoveUserRequest Body { get; init; }
}
