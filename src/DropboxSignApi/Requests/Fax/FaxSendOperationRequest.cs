using System.Collections.Generic;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Requests.Fax;

/// <summary>
/// The inputs of the FaxSend operation.
/// </summary>
public sealed record FaxSendOperationRequest
{
    /// <summary>
    /// Recipient of the fax
    /// Can be a phone number in E.164 format or email address
    /// </summary>
    public required string Recipient { get; init; }

    /// <summary>
    /// Fax Send From Sender (used only with fax number)
    /// </summary>
    public string? Sender { get; init; }

    /// <summary>
    /// Use <c>files[]</c> to indicate the uploaded file(s) to fax
    /// <para>
    /// This endpoint requires either <b>files</b> or <b>file_urls[]</b>, but not both.
    /// </para>
    /// </summary>
    public BinaryContent? Files { get; init; }

    /// <summary>
    /// Use <c>file_urls[]</c> to have Dropbox Fax download the file(s) to fax
    /// <para>
    /// This endpoint requires either <b>files</b> or <b>file_urls[]</b>, but not both.
    /// </para>
    /// </summary>
    public IReadOnlyList<string>? FileUrls { get; init; }

    /// <summary>
    /// API Test Mode Setting
    /// </summary>
    public bool TestMode { get; init; } = false;

    /// <summary>
    /// Fax cover page recipient information
    /// </summary>
    public string? CoverPageTo { get; init; }

    /// <summary>
    /// Fax cover page sender information
    /// </summary>
    public string? CoverPageFrom { get; init; }

    /// <summary>
    /// Fax Cover Page Message
    /// </summary>
    public string? CoverPageMessage { get; init; }

    /// <summary>
    /// Fax Title
    /// </summary>
    public string? Title { get; init; }
}
