using System.Threading.Tasks;
using DropboxSignApi.Core.ErrorResponse;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models;

namespace DropboxSignApi.Errors;

public sealed class UnclaimedDraftEditAndResendError : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private UnclaimedDraftEditAndResendError(Optional<ErrorResponseModel> errorResponseModelValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static UnclaimedDraftEditAndResendError AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static UnclaimedDraftEditAndResendError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    private static Task<UnclaimedDraftEditAndResendError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            >= 400 and <= 499 => response.Json<ErrorResponseModel>().As(AsErrorResponseModel),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<UnclaimedDraftEditAndResendError> Response { get; } = new(Create);
}
