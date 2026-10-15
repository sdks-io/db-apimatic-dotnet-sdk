namespace DropboxSignApi.Requests.Fax;

/// <summary>
/// The inputs of the FaxDelete operation.
/// </summary>
public sealed record FaxDeleteRequest
{
    /// <summary>
    /// Fax ID
    /// </summary>
    public required string FaxId { get; init; }
}
