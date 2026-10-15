namespace DropboxSignApi.Requests.Fax;

/// <summary>
/// The inputs of the FaxFiles operation.
/// </summary>
public sealed record FaxFilesRequest
{
    /// <summary>
    /// Fax ID
    /// </summary>
    public required string FaxId { get; init; }
}
