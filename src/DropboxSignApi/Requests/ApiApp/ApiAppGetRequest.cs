namespace DropboxSignApi.Requests.ApiApp;

/// <summary>
/// The inputs of the ApiAppGet operation.
/// </summary>
public sealed record ApiAppGetRequest
{
    /// <summary>
    /// The client id of the API App to retrieve.
    /// </summary>
    public required string ClientId { get; init; }
}
