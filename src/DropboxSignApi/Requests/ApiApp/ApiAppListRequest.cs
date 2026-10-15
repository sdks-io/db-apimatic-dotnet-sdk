namespace DropboxSignApi.Requests.ApiApp;

/// <summary>
/// The inputs of the ApiAppList operation.
/// </summary>
public sealed record ApiAppListRequest
{
    /// <summary>
    /// Which page number of the API App List to return. Defaults to <c>1</c>.
    /// </summary>
    public int Page { get; init; } = 1;

    /// <summary>
    /// Number of objects to be returned per page. Must be between <c>1</c> and <c>100</c>. Default is <c>20</c>.
    /// </summary>
    public int PageSize { get; init; } = 20;
}
