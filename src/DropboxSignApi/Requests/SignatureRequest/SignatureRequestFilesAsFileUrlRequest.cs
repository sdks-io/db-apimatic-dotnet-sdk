namespace DropboxSignApi.Requests.SignatureRequest;

/// <summary>
/// The inputs of the SignatureRequestFilesAsFileUrl operation.
/// </summary>
public sealed record SignatureRequestFilesAsFileUrlRequest
{
    /// <summary>
    /// The id of the SignatureRequest to retrieve.
    /// </summary>
    public required string SignatureRequestId { get; init; }

    /// <summary>
    /// By default when opening the <c>file_url</c> a browser will download the PDF and save it locally. When set to <c>0</c> the PDF file will be displayed in the browser.
    /// </summary>
    public int ForceDownload { get; init; } = 1;
}
