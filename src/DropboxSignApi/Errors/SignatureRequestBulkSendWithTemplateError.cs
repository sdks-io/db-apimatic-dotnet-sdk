using System.Threading.Tasks;
using DropboxSignApi.Core.ErrorResponse;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models;

namespace DropboxSignApi.Errors;

public sealed class SignatureRequestBulkSendWithTemplateError : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private SignatureRequestBulkSendWithTemplateError(Optional<ErrorResponseModel> errorResponseModelValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static SignatureRequestBulkSendWithTemplateError AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static SignatureRequestBulkSendWithTemplateError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    private static Task<SignatureRequestBulkSendWithTemplateError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            >= 400 and <= 499 => response.Json<ErrorResponseModel>().As(AsErrorResponseModel),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<SignatureRequestBulkSendWithTemplateError> Response { get; } = new(Create);
}
