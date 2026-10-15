namespace DropboxSignApi.Requests.Template;

/// <summary>
/// The inputs of the TemplateFilesAsDataUri operation.
/// </summary>
public sealed record TemplateFilesAsDataUriRequest
{
    /// <summary>
    /// The id of the template files to retrieve.
    /// </summary>
    public required string TemplateId { get; init; }
}
