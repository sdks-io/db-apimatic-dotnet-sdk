<!-- Generated file — do not edit; regenerated with the SDK. -->

# Embedded — operations

Accessor: `client.Embedded` · Source: `src/DropboxSignApi/Api/Embedded.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### EmbeddedEditUrl

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `EmbeddedEditUrl(EmbeddedEditUrlOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TemplateId`, `Body`
- **Returns**: `EmbeddedEditUrlResponse`
- **Error**: `ApiException<EmbeddedEditUrlError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EmbeddedEditUrlOperationRequest` | `src/DropboxSignApi/Requests/Embedded/EmbeddedEditUrlOperationRequest.cs` |
| `EmbeddedEditUrlRequest` | `src/DropboxSignApi/Models/EmbeddedEditUrlRequest.cs` |
| `EmbeddedEditUrlResponse` | `src/DropboxSignApi/Models/EmbeddedEditUrlResponse.cs` |
| `EmbeddedEditUrlError` | `src/DropboxSignApi/Errors/EmbeddedEditUrlError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### EmbeddedSignUrl

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `EmbeddedSignUrl(EmbeddedSignUrlRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SignatureId`
- **Returns**: `EmbeddedSignUrlResponse`
- **Error**: `ApiException<EmbeddedSignUrlError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EmbeddedSignUrlRequest` | `src/DropboxSignApi/Requests/Embedded/EmbeddedSignUrlRequest.cs` |
| `EmbeddedSignUrlResponse` | `src/DropboxSignApi/Models/EmbeddedSignUrlResponse.cs` |
| `EmbeddedSignUrlError` | `src/DropboxSignApi/Errors/EmbeddedSignUrlError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

