namespace DropboxSignApi.Requests.BulkSendJob;

/// <summary>
/// The inputs of the BulkSendJobGet operation.
/// </summary>
public sealed record BulkSendJobGetRequest
{
    /// <summary>
    /// The id of the BulkSendJob to retrieve.
    /// </summary>
    public required string BulkSendJobId { get; init; }

    /// <summary>
    /// Which page number of the BulkSendJob list to return. Defaults to <c>1</c>.
    /// </summary>
    public int Page { get; init; } = 1;

    /// <summary>
    /// Number of objects to be returned per page. Must be between <c>1</c> and <c>100</c>. Default is 20.
    /// </summary>
    public int PageSize { get; init; } = 20;
}
