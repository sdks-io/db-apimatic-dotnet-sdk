<!-- Generated file — do not edit; regenerated with the SDK. -->

# BulkSendJob — operations

Accessor: `client.BulkSendJob` · Source: `src/DropboxSignApi/Api/BulkSendJob.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkSendJobGet

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `BulkSendJobGet(BulkSendJobGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BulkSendJobId`
- **Query params (wire ← C#)**: `page` ← `Page`, `page_size` ← `PageSize`
- **Returns**: `BulkSendJobGetResponse`
- **Error**: `ApiException<BulkSendJobGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BulkSendJobGetRequest` | `src/DropboxSignApi/Requests/BulkSendJob/BulkSendJobGetRequest.cs` |
| `BulkSendJobGetResponse` | `src/DropboxSignApi/Models/BulkSendJobGetResponse.cs` |
| `BulkSendJobGetError` | `src/DropboxSignApi/Errors/BulkSendJobGetError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### BulkSendJobList

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `BulkSendJobList(BulkSendJobListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`, `page_size` ← `PageSize`
- **Returns**: `BulkSendJobListResponse`
- **Error**: `ApiException<BulkSendJobListError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BulkSendJobListRequest` | `src/DropboxSignApi/Requests/BulkSendJob/BulkSendJobListRequest.cs` |
| `BulkSendJobListResponse` | `src/DropboxSignApi/Models/BulkSendJobListResponse.cs` |
| `BulkSendJobListError` | `src/DropboxSignApi/Errors/BulkSendJobListError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

