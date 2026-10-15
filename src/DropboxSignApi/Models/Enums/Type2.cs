using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

/// <summary>
/// The type of unclaimed draft to create. Use <c>send_document</c> to create a claimable file, and <c>request_signature</c> for a claimable signature request. If the type is <c>request_signature</c> then signers name and email_address are not optional.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type2>))]
public sealed record Type2 : OpenStringEnum<Type2>
{
    private Type2(string value) : base(value)
    {
    }

    public static readonly Type2 SendDocument = new("send_document");

    public static readonly Type2 RequestSignature = new("request_signature");

    public TResult Match<TResult>(Func<TResult> onSendDocument,
        Func<TResult> onRequestSignature,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SendDocument => onSendDocument(),
            _ when this == RequestSignature => onRequestSignature(),
            _ => otherwise(Value)
        };

    public void Match(Action onSendDocument, Action onRequestSignature, Action<string> otherwise)
    {
        if (this == SendDocument) onSendDocument();
        else if (this == RequestSignature) onRequestSignature();
        else otherwise(Value);
    }
}
