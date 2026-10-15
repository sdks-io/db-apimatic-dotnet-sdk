namespace DropboxSignApi.Requests.Template;

/// <summary>
/// The inputs of the TemplateGet operation.
/// </summary>
public sealed record TemplateGetRequest
{
    /// <summary>
    /// The id of the Template to retrieve.
    /// </summary>
    public required string TemplateId { get; init; }
}
