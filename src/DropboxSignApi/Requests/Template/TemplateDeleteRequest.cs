namespace DropboxSignApi.Requests.Template;

/// <summary>
/// The inputs of the TemplateDelete operation.
/// </summary>
public sealed record TemplateDeleteRequest
{
    /// <summary>
    /// The id of the Template to delete.
    /// </summary>
    public required string TemplateId { get; init; }
}
