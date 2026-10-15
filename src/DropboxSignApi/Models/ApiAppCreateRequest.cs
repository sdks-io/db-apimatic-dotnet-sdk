using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record ApiAppCreateRequest
{
    /// <summary>
    /// The URL at which the ApiApp should receive event callbacks.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("callback_url")]
    public string? CallbackUrl { get; init; }

    /// <summary>
    /// An image file to use as a custom logo in embedded contexts. (Only applies to some API plans)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_logo_file")]
    public BinaryContent? CustomLogoFile { get; init; }

    /// <summary>
    /// The domain names the ApiApp will be associated with.
    /// </summary>
    [JsonPropertyName("domains")]
    [MinLength(1)]
    [MaxLength(10)]
    public required IReadOnlyList<string> Domains { get; init; }

    /// <summary>
    /// The name you want to assign to the ApiApp.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// OAuth related parameters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("oauth")]
    public SubOAuth? Oauth { get; init; }

    /// <summary>
    /// Additional options supported by API App.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public SubOptions? Options { get; init; }

    /// <summary>
    /// An array of elements and values serialized to a string, to be used to customize the app's signer page. (Only applies to some API plans)
    /// <para>
    /// Take a look at our <see href="https://developers.hellosign.com/api/reference/premium-branding/">white labeling guide</see> to learn more.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("white_labeling_options")]
    public SubWhiteLabelingOptions? WhiteLabelingOptions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
