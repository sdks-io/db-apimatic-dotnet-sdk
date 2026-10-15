using System.Threading.Tasks;
using DropboxSignApi.Core.ErrorResponse;
using DropboxSignApi.Core.Models;
using DropboxSignApi.Models;

namespace DropboxSignApi.Errors;

public sealed class UnclaimedDraftCreateEmbeddedWithTemplateError : ApiError
{
    private readonly Optional<ErrorResponseModel> _errorResponseModelValue;

    private UnclaimedDraftCreateEmbeddedWithTemplateError(Optional<ErrorResponseModel> errorResponseModelValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorResponseModelValue = errorResponseModelValue;
    }

    private static UnclaimedDraftCreateEmbeddedWithTemplateError AsErrorResponseModel(ErrorResponseModel value) =>
        new(Optional<ErrorResponseModel>.Some(value), default);

    private static UnclaimedDraftCreateEmbeddedWithTemplateError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorResponseModel(out ErrorResponseModel value) =>
        _errorResponseModelValue.TryGetValue(out value);

    private static Task<UnclaimedDraftCreateEmbeddedWithTemplateError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            >= 400 and <= 499 => response.Json<ErrorResponseModel>().As(AsErrorResponseModel),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<UnclaimedDraftCreateEmbeddedWithTemplateError> Response { get; } = new(Create);
}
