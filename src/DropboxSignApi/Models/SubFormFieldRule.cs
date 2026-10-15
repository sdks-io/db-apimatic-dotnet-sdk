using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Models;

public record SubFormFieldRule
{
    /// <summary>
    /// Must be unique across all defined rules.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Currently only <c>AND</c> is supported. Support for <c>OR</c> is being worked on.
    /// </summary>
    [JsonPropertyName("trigger_operator")]
    public string TriggerOperator { get; init; } = "AND";

    /// <summary>
    /// An array of trigger definitions, the "if this" part of "<b>if this</b>, then that". Currently only a single trigger per rule is allowed.
    /// </summary>
    [JsonPropertyName("triggers")]
    [MinLength(1)]
    [MaxLength(1)]
    public required IReadOnlyList<SubFormFieldRuleTrigger> Triggers { get; init; }

    /// <summary>
    /// An array of action definitions, the "then that" part of "if this, <b>then that</b>". Any number of actions may be attached to a single rule.
    /// </summary>
    [JsonPropertyName("actions")]
    [MinLength(1)]
    public required IReadOnlyList<SubFormFieldRuleAction> Actions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
