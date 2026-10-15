namespace DropboxSignApi.Requests.Embedded;

/// <summary>
/// The inputs of the EmbeddedSignUrl operation.
/// </summary>
public sealed record EmbeddedSignUrlRequest
{
    /// <summary>
    /// The id of the signature to get a signature url for.
    /// </summary>
    public required string SignatureId { get; init; }
}
