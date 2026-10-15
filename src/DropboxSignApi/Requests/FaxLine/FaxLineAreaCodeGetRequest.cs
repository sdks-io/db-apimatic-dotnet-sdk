using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Requests.FaxLine;

/// <summary>
/// The inputs of the FaxLineAreaCodeGet operation.
/// </summary>
public sealed record FaxLineAreaCodeGetRequest
{
    /// <summary>
    /// Filter area codes by country
    /// </summary>
    public required FaxLineAreaCodeGetCountryEnum Country { get; init; }

    /// <summary>
    /// Filter area codes by state
    /// </summary>
    public FaxLineAreaCodeGetStateEnum? State { get; init; }

    /// <summary>
    /// Filter area codes by province
    /// </summary>
    public FaxLineAreaCodeGetProvinceEnum? Province { get; init; }

    /// <summary>
    /// Filter area codes by city
    /// </summary>
    public string? City { get; init; }
}
