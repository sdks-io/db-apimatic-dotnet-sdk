using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Requests.SignatureRequest;

/// <summary>
/// The inputs of the SignatureRequestFiles operation.
/// </summary>
public sealed record SignatureRequestFilesRequest
{
    /// <summary>
    /// The id of the SignatureRequest to retrieve.
    /// </summary>
    public required string SignatureRequestId { get; init; }

    /// <summary>
    /// Set to <c>pdf</c> for a single merged document or <c>zip</c> for a collection of individual documents.
    /// </summary>
    public FileType FileType { get; init; } = FileType.Pdf;
}
