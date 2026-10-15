using DropboxSignApi.Core.Validation.Attributes;

namespace DropboxSignApi.Requests.Fax;

/// <summary>
/// The inputs of the FaxList operation.
/// </summary>
public sealed record FaxListRequest
{
    /// <summary>
    /// Which page number of the Fax List to return. Defaults to <c>1</c>.
    /// </summary>
    [Minimum(1)]
    public int Page { get; init; } = 1;

    /// <summary>
    /// Number of objects to be returned per page. Must be between <c>1</c> and <c>100</c>. Default is <c>20</c>.
    /// </summary>
    [Minimum(1)]
    [Maximum(100)]
    public int PageSize { get; init; } = 20;
}
