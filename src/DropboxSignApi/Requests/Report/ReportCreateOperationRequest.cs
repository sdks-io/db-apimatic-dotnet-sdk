using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.Report;

/// <summary>
/// The inputs of the ReportCreate operation.
/// </summary>
public sealed record ReportCreateOperationRequest
{
    public required ReportCreateRequest Body { get; init; }
}
