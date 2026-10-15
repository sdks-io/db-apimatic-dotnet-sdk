using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.Template;

/// <summary>
/// The inputs of the TemplateAddUser operation.
/// </summary>
public sealed record TemplateAddUserOperationRequest
{
    /// <summary>
    /// The id of the Template to give the Account access to.
    /// </summary>
    public required string TemplateId { get; init; }

    public required TemplateAddUserRequest Body { get; init; }
}
