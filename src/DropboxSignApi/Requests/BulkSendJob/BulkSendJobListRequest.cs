namespace DropboxSignApi.Requests.BulkSendJob;

/// <summary>
/// The inputs of the BulkSendJobList operation.
/// </summary>
public sealed record BulkSendJobListRequest
{
    /// <summary>
    /// Which page number of the BulkSendJob List to return. Defaults to <c>1</c>.
    /// </summary>
    public int Page { get; init; } = 1;

    /// <summary>
    /// Number of objects to be returned per page. Must be between <c>1</c> and <c>100</c>. Default is 20.
    /// </summary>
    public int PageSize { get; init; } = 20;
}
