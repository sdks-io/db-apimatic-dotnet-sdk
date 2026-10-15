namespace DropboxSignApi.Requests.FaxLine;

/// <summary>
/// The inputs of the FaxLineGet operation.
/// </summary>
public sealed record FaxLineGetRequest
{
    /// <summary>
    /// The Fax Line number
    /// </summary>
    public required string Number { get; init; }
}
