<!-- Generated file — do not edit; regenerated with the SDK. -->

# ApiApp — operations

Accessor: `client.ApiApp` · Source: `src/DropboxSignApi/Api/ApiApp.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ApiAppCreate

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `ApiAppCreate(ApiAppCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Domains`, `Name`
- **Returns**: `ApiAppGetResponse`
- **Error**: `ApiException<ApiAppCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiAppCreateOperationRequest` | `src/DropboxSignApi/Requests/ApiApp/ApiAppCreateOperationRequest.cs` |
| `SubOAuth` | `src/DropboxSignApi/Models/SubOAuth.cs` |
| `SubOptions` | `src/DropboxSignApi/Models/SubOptions.cs` |
| `SubWhiteLabelingOptions` | `src/DropboxSignApi/Models/SubWhiteLabelingOptions.cs` |
| `ApiAppGetResponse` | `src/DropboxSignApi/Models/ApiAppGetResponse.cs` |
| `ApiAppCreateError` | `src/DropboxSignApi/Errors/ApiAppCreateError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### ApiAppDelete

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `ApiAppDelete(ApiAppDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClientId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<ApiAppDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiAppDeleteRequest` | `src/DropboxSignApi/Requests/ApiApp/ApiAppDeleteRequest.cs` |
| `ApiAppDeleteError` | `src/DropboxSignApi/Errors/ApiAppDeleteError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### ApiAppGet

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `ApiAppGet(ApiAppGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClientId`
- **Returns**: `ApiAppGetResponse`
- **Error**: `ApiException<ApiAppGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiAppGetRequest` | `src/DropboxSignApi/Requests/ApiApp/ApiAppGetRequest.cs` |
| `ApiAppGetResponse` | `src/DropboxSignApi/Models/ApiAppGetResponse.cs` |
| `ApiAppGetError` | `src/DropboxSignApi/Errors/ApiAppGetError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### ApiAppList

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `ApiAppList(ApiAppListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`, `page_size` ← `PageSize`
- **Returns**: `ApiAppListResponse`
- **Error**: `ApiException<ApiAppListError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiAppListRequest` | `src/DropboxSignApi/Requests/ApiApp/ApiAppListRequest.cs` |
| `ApiAppListResponse` | `src/DropboxSignApi/Models/ApiAppListResponse.cs` |
| `ApiAppListError` | `src/DropboxSignApi/Errors/ApiAppListError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### ApiAppUpdate

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `ApiAppUpdate(ApiAppUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClientId`
- **Returns**: `ApiAppGetResponse`
- **Error**: `ApiException<ApiAppUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiAppUpdateOperationRequest` | `src/DropboxSignApi/Requests/ApiApp/ApiAppUpdateOperationRequest.cs` |
| `SubOAuth` | `src/DropboxSignApi/Models/SubOAuth.cs` |
| `SubOptions` | `src/DropboxSignApi/Models/SubOptions.cs` |
| `SubWhiteLabelingOptions` | `src/DropboxSignApi/Models/SubWhiteLabelingOptions.cs` |
| `ApiAppGetResponse` | `src/DropboxSignApi/Models/ApiAppGetResponse.cs` |
| `ApiAppUpdateError` | `src/DropboxSignApi/Errors/ApiAppUpdateError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

