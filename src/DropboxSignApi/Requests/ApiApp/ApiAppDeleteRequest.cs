namespace DropboxSignApi.Requests.ApiApp;

/// <summary>
/// The inputs of the ApiAppDelete operation.
/// </summary>
public sealed record ApiAppDeleteRequest
{
    /// <summary>
    /// The client id of the API App to delete.
    /// </summary>
    public required string ClientId { get; init; }
}
