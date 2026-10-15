<!-- Generated file — do not edit; regenerated with the SDK. -->

# Fax — operations

Accessor: `client.Fax` · Source: `src/DropboxSignApi/Api/Fax.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### FaxDelete

- **Auth**: `options.ApiKey`
- **Signature**: `FaxDelete(FaxDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `FaxId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<FaxDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FaxDeleteRequest` | `src/DropboxSignApi/Requests/Fax/FaxDeleteRequest.cs` |
| `FaxDeleteError` | `src/DropboxSignApi/Errors/FaxDeleteError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### FaxFiles

- **Auth**: `options.ApiKey`
- **Signature**: `FaxFiles(FaxFilesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `FaxId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<FaxFilesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FaxFilesRequest` | `src/DropboxSignApi/Requests/Fax/FaxFilesRequest.cs` |
| `FaxFilesError` | `src/DropboxSignApi/Errors/FaxFilesError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### FaxGet

- **Auth**: `options.ApiKey`
- **Signature**: `FaxGet(FaxGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `FaxId`
- **Returns**: `FaxGetResponse`
- **Error**: `ApiException<FaxGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FaxGetRequest` | `src/DropboxSignApi/Requests/Fax/FaxGetRequest.cs` |
| `FaxGetResponse` | `src/DropboxSignApi/Models/FaxGetResponse.cs` |
| `FaxGetError` | `src/DropboxSignApi/Errors/FaxGetError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### FaxList

- **Auth**: `options.ApiKey`
- **Signature**: `FaxList(FaxListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`, `page_size` ← `PageSize`
- **Returns**: `FaxListResponse`
- **Error**: `ApiException<FaxListError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FaxListRequest` | `src/DropboxSignApi/Requests/Fax/FaxListRequest.cs` |
| `FaxListResponse` | `src/DropboxSignApi/Models/FaxListResponse.cs` |
| `FaxListError` | `src/DropboxSignApi/Errors/FaxListError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### FaxSend

- **Auth**: `options.ApiKey`
- **Signature**: `FaxSend(FaxSendOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Recipient`
- **Returns**: `FaxGetResponse`
- **Error**: `ApiException<FaxSendError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FaxSendOperationRequest` | `src/DropboxSignApi/Requests/Fax/FaxSendOperationRequest.cs` |
| `FaxGetResponse` | `src/DropboxSignApi/Models/FaxGetResponse.cs` |
| `FaxSendError` | `src/DropboxSignApi/Errors/FaxSendError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

