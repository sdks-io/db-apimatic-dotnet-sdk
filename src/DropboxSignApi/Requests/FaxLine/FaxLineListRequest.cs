namespace DropboxSignApi.Requests.FaxLine;

/// <summary>
/// The inputs of the FaxLineList operation.
/// </summary>
public sealed record FaxLineListRequest
{
    /// <summary>
    /// Account ID
    /// </summary>
    public string? AccountId { get; init; }

    /// <summary>
    /// Which page number of the Fax Line List to return. Defaults to <c>1</c>.
    /// </summary>
    public int Page { get; init; } = 1;

    /// <summary>
    /// Number of objects to be returned per page. Must be between <c>1</c> and <c>100</c>. Default is <c>20</c>.
    /// </summary>
    public int PageSize { get; init; } = 20;

    /// <summary>
    /// Include Fax Lines belonging to team members in the list
    /// </summary>
    public bool? ShowTeamLines { get; init; }
}
