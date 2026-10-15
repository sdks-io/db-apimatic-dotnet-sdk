using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Core.Validation;
using DropboxSignApi.Core.Validation.Attributes;

namespace DropboxSignApi.Models;

public record UnclaimedDraftEditAndResendRequest
{
    /// <summary>
    /// Client id of the app used to create the draft. Used to apply the branding and callback url defined for the app.
    /// </summary>
    [JsonPropertyName("client_id")]
    public required string ClientId { get; init; }

    /// <summary>
    /// This allows the requester to specify editor options when a preparing a document
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("editor_options")]
    public SubEditorOptions? EditorOptions { get; init; }

    /// <summary>
    /// The request created from this draft will also be signable in embedded mode if set to <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_for_embedded_signing")]
    public bool? IsForEmbeddedSigning { get; init; }

    /// <summary>
    /// The email address of the user that should be designated as the requester of this draft. If not set, original requester's email address will be used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requester_email_address")]
    [Format(FormatKind.Email)]
    public string? RequesterEmailAddress { get; init; }

    /// <summary>
    /// The URL you want signers redirected to after they successfully request a signature.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requesting_redirect_url")]
    public string? RequestingRedirectUrl { get; init; }

    /// <summary>
    /// When only one step remains in the signature request process and this parameter is set to <c>false</c> then the progress stepper will be hidden.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("show_progress_stepper")]
    public bool? ShowProgressStepper { get; init; } = true;

    /// <summary>
    /// The URL you want signers redirected to after they successfully sign.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signing_redirect_url")]
    public string? SigningRedirectUrl { get; init; }

    /// <summary>
    /// Whether this is a test, the signature request created from this draft will not be legally binding if set to <c>true</c>. Defaults to <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("test_mode")]
    public bool? TestMode { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
