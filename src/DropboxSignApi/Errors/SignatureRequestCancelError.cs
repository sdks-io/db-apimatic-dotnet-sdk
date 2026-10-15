using System.Threading.Tasks;
using DropboxSignApi.Core.ErrorResponse;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models;

namespace DropboxSignApi.Errors;

public sealed class SignatureRequestCancelError : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private SignatureRequestCancelError(Optional<ErrorResponseModel> errorResponseModelValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static SignatureRequestCancelError AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static SignatureRequestCancelError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    private static Task<SignatureRequestCancelError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            >= 400 and <= 499 => response.Json<ErrorResponseModel>().As(AsErrorResponseModel),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<SignatureRequestCancelError> Response { get; } = new(Create);
}
