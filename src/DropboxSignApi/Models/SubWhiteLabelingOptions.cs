using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models.Enums;

namespace DropboxSignApi.Models;

/// <summary>
/// An array of elements and values serialized to a string, to be used to customize the app's signer page. (Only applies to some API plans)
/// <para>
/// Take a look at our <see href="https://developers.hellosign.com/api/reference/premium-branding/">white labeling guide</see> to learn more.
/// </para>
/// </summary>
public record SubWhiteLabelingOptions
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("header_background_color")]
    public string? HeaderBackgroundColor { get; init; } = "#1a1a1a";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legal_version")]
    public LegalVersion? LegalVersion { get; init; } = LegalVersion.Terms1;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link_color")]
    public string? LinkColor { get; init; } = "#0061FE";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("page_background_color")]
    public string? PageBackgroundColor { get; init; } = "#f7f8f9";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primary_button_color")]
    public string? PrimaryButtonColor { get; init; } = "#0061FE";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primary_button_color_hover")]
    public string? PrimaryButtonColorHover { get; init; } = "#0061FE";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primary_button_text_color")]
    public string? PrimaryButtonTextColor { get; init; } = "#ffffff";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primary_button_text_color_hover")]
    public string? PrimaryButtonTextColorHover { get; init; } = "#ffffff";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secondary_button_color")]
    public string? SecondaryButtonColor { get; init; } = "#ffffff";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secondary_button_color_hover")]
    public string? SecondaryButtonColorHover { get; init; } = "#ffffff";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secondary_button_text_color")]
    public string? SecondaryButtonTextColor { get; init; } = "#0061FE";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secondary_button_text_color_hover")]
    public string? SecondaryButtonTextColorHover { get; init; } = "#0061FE";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("text_color1")]
    public string? TextColor1 { get; init; } = "#808080";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("text_color2")]
    public string? TextColor2 { get; init; } = "#ffffff";

    /// <summary>
    /// Resets white labeling options to defaults. Only useful when updating an API App.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reset_to_default")]
    public bool? ResetToDefault { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
