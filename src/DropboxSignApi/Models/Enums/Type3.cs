using System;
using System.Text.Json.Serialization;
using DropboxSignApi.Core.Enum;

namespace DropboxSignApi.Models.Enums;

/// <summary>
/// The type of the draft. By default this is <c>request_signature</c>, but you can set it to <c>send_document</c> if you want to self sign a document and download it.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type3>))]
public sealed record Type3 : OpenStringEnum<Type3>
{
    private Type3(string value) : base(value)
    {
    }

    public static readonly Type3 SendDocument = new("send_document");

    public static readonly Type3 RequestSignature = new("request_signature");

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
