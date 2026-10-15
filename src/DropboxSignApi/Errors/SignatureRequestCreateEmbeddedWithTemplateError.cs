using System.Threading.Tasks;
using DropboxSignApi.Core.ErrorResponse;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models;

namespace DropboxSignApi.Errors;

public sealed class SignatureRequestCreateEmbeddedWithTemplateError : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private SignatureRequestCreateEmbeddedWithTemplateError(Optional<ErrorResponseModel> errorResponseModelValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static SignatureRequestCreateEmbeddedWithTemplateError AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static SignatureRequestCreateEmbeddedWithTemplateError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    private static Task<SignatureRequestCreateEmbeddedWithTemplateError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            >= 400 and <= 499 => response.Json<ErrorResponseModel>().As(AsErrorResponseModel),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<SignatureRequestCreateEmbeddedWithTemplateError> Response { get; } = new(Create);
}
