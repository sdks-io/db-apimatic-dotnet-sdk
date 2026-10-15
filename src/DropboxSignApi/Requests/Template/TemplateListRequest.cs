using DropboxSignApi.Core.Validation.Attributes;

namespace DropboxSignApi.Requests.Template;

/// <summary>
/// The inputs of the TemplateList operation.
/// </summary>
public sealed record TemplateListRequest
{
    /// <summary>
    /// Which account to return Templates for. Must be a team member. Use <c>all</c> to indicate all team members. Defaults to your account.
    /// </summary>
    public string? AccountId { get; init; }

    /// <summary>
    /// Which page number of the Template List to return. Defaults to <c>1</c>.
    /// </summary>
    public int Page { get; init; } = 1;

    /// <summary>
    /// Number of objects to be returned per page. Must be between <c>1</c> and <c>100</c>. Default is <c>20</c>.
    /// </summary>
    [Minimum(1)]
    [Maximum(100)]
    public int PageSize { get; init; } = 20;

    /// <summary>
    /// String that includes search terms and/or fields to be used to filter the Template objects.
    /// </summary>
    public string? Query { get; init; }
}
