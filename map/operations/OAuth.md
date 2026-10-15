<!-- Generated file — do not edit; regenerated with the SDK. -->

# OAuth — operations

Accessor: `client.OAuth` · Source: `src/DropboxSignApi/Api/OAuth.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### OauthTokenGenerate

- **Signature**: `OauthTokenGenerate(OauthTokenGenerateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `OAuthTokenResponse`
- **Error**: `ApiException<OauthTokenGenerateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OauthTokenGenerateOperationRequest` | `src/DropboxSignApi/Requests/OAuth/OauthTokenGenerateOperationRequest.cs` |
| `OAuthTokenGenerateRequest` | `src/DropboxSignApi/Models/OAuthTokenGenerateRequest.cs` |
| `OAuthTokenResponse` | `src/DropboxSignApi/Models/OAuthTokenResponse.cs` |
| `OauthTokenGenerateError` | `src/DropboxSignApi/Errors/OauthTokenGenerateError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### OauthTokenRefresh

- **Signature**: `OauthTokenRefresh(OauthTokenRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `OAuthTokenResponse`
- **Error**: `ApiException<OauthTokenRefreshError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OauthTokenRefreshOperationRequest` | `src/DropboxSignApi/Requests/OAuth/OauthTokenRefreshOperationRequest.cs` |
| `OAuthTokenRefreshRequest` | `src/DropboxSignApi/Models/OAuthTokenRefreshRequest.cs` |
| `OAuthTokenResponse` | `src/DropboxSignApi/Models/OAuthTokenResponse.cs` |
| `OauthTokenRefreshError` | `src/DropboxSignApi/Errors/OauthTokenRefreshError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

