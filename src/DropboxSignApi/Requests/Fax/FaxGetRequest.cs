namespace DropboxSignApi.Requests.Fax;

/// <summary>
/// The inputs of the FaxGet operation.
/// </summary>
public sealed record FaxGetRequest
{
    /// <summary>
    /// Fax ID
    /// </summary>
    public required string FaxId { get; init; }
}
