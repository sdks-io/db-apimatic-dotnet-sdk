using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models;

namespace DropboxSignApi.Requests.ApiApp;

/// <summary>
/// The inputs of the ApiAppCreate operation.
/// </summary>
public sealed record ApiAppCreateOperationRequest
{
    /// <summary>
    /// The domain names the ApiApp will be associated with.
    /// </summary>
    [MinLength(1)]
    [MaxLength(10)]
    public required IReadOnlyList<string> Domains { get; init; }

    /// <summary>
    /// The name you want to assign to the ApiApp.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// The URL at which the ApiApp should receive event callbacks.
    /// </summary>
    public string? CallbackUrl { get; init; }

    /// <summary>
    /// An image file to use as a custom logo in embedded contexts. (Only applies to some API plans)
    /// </summary>
    public BinaryContent? CustomLogoFile { get; init; }

    /// <summary>
    /// OAuth related parameters.
    /// </summary>
    public SubOAuth? Oauth { get; init; }

    /// <summary>
    /// Additional options supported by API App.
    /// </summary>
    public SubOptions? Options { get; init; }

    /// <summary>
    /// An array of elements and values serialized to a string, to be used to customize the app's signer page. (Only applies to some API plans)
    /// <para>
    /// Take a look at our <see href="https://developers.hellosign.com/api/reference/premium-branding/">white labeling guide</see> to learn more.
    /// </para>
    /// </summary>
    public SubWhiteLabelingOptions? WhiteLabelingOptions { get; init; }
}
