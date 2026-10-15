namespace DropboxSignApi.Requests.Template;

/// <summary>
/// The inputs of the TemplateFilesAsFileUrl operation.
/// </summary>
public sealed record TemplateFilesAsFileUrlRequest
{
    /// <summary>
    /// The id of the template files to retrieve.
    /// </summary>
    public required string TemplateId { get; init; }

    /// <summary>
    /// By default when opening the <c>file_url</c> a browser will download the PDF and save it locally. When set to <c>0</c> the PDF file will be displayed in the browser.
    /// </summary>
    public int ForceDownload { get; init; } = 1;
}
