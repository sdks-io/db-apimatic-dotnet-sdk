<!-- Generated file — do not edit; regenerated with the SDK. -->

# FaxLine — operations

Accessor: `client.FaxLine` · Source: `src/DropboxSignApi/Api/FaxLine.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### FaxLineAddUser

- **Auth**: `options.ApiKey`
- **Signature**: `FaxLineAddUser(FaxLineAddUserOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `FaxLineResponse`
- **Error**: `ApiException<FaxLineAddUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FaxLineAddUserOperationRequest` | `src/DropboxSignApi/Requests/FaxLine/FaxLineAddUserOperationRequest.cs` |
| `FaxLineAddUserRequest` | `src/DropboxSignApi/Models/FaxLineAddUserRequest.cs` |
| `FaxLineResponse` | `src/DropboxSignApi/Models/FaxLineResponse.cs` |
| `FaxLineAddUserError` | `src/DropboxSignApi/Errors/FaxLineAddUserError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### FaxLineAreaCodeGet

- **Auth**: `options.ApiKey`
- **Signature**: `FaxLineAreaCodeGet(FaxLineAreaCodeGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Country`
- **Query params (wire ← C#)**: `country` ← `Country`, `state` ← `State`, `province` ← `Province`, `city` ← `City`
- **Returns**: `FaxLineAreaCodeGetResponse`
- **Error**: `ApiException<FaxLineAreaCodeGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FaxLineAreaCodeGetRequest` | `src/DropboxSignApi/Requests/FaxLine/FaxLineAreaCodeGetRequest.cs` |
| `FaxLineAreaCodeGetCountryEnum` | `src/DropboxSignApi/Models/Enums/FaxLineAreaCodeGetCountryEnum.cs` |
| `FaxLineAreaCodeGetStateEnum` | `src/DropboxSignApi/Models/Enums/FaxLineAreaCodeGetStateEnum.cs` |
| `FaxLineAreaCodeGetProvinceEnum` | `src/DropboxSignApi/Models/Enums/FaxLineAreaCodeGetProvinceEnum.cs` |
| `FaxLineAreaCodeGetResponse` | `src/DropboxSignApi/Models/FaxLineAreaCodeGetResponse.cs` |
| `FaxLineAreaCodeGetError` | `src/DropboxSignApi/Errors/FaxLineAreaCodeGetError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### FaxLineCreate

- **Auth**: `options.ApiKey`
- **Signature**: `FaxLineCreate(FaxLineCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `FaxLineResponse`
- **Error**: `ApiException<FaxLineCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FaxLineCreateOperationRequest` | `src/DropboxSignApi/Requests/FaxLine/FaxLineCreateOperationRequest.cs` |
| `FaxLineCreateRequest` | `src/DropboxSignApi/Models/FaxLineCreateRequest.cs` |
| `FaxLineResponse` | `src/DropboxSignApi/Models/FaxLineResponse.cs` |
| `FaxLineCreateError` | `src/DropboxSignApi/Errors/FaxLineCreateError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### FaxLineDelete

- **Auth**: `options.ApiKey`
- **Signature**: `FaxLineDelete(FaxLineDeleteOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `object`
- **Error**: `ApiException<FaxLineDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FaxLineDeleteOperationRequest` | `src/DropboxSignApi/Requests/FaxLine/FaxLineDeleteOperationRequest.cs` |
| `FaxLineDeleteRequest` | `src/DropboxSignApi/Models/FaxLineDeleteRequest.cs` |
| `FaxLineDeleteError` | `src/DropboxSignApi/Errors/FaxLineDeleteError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### FaxLineGet

- **Auth**: `options.ApiKey`
- **Signature**: `FaxLineGet(FaxLineGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Number`
- **Query params (wire ← C#)**: `number` ← `Number`
- **Returns**: `FaxLineResponse`
- **Error**: `ApiException<FaxLineGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FaxLineGetRequest` | `src/DropboxSignApi/Requests/FaxLine/FaxLineGetRequest.cs` |
| `FaxLineResponse` | `src/DropboxSignApi/Models/FaxLineResponse.cs` |
| `FaxLineGetError` | `src/DropboxSignApi/Errors/FaxLineGetError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### FaxLineList

- **Auth**: `options.ApiKey`
- **Signature**: `FaxLineList(FaxLineListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `account_id` ← `AccountId`, `page` ← `Page`, `page_size` ← `PageSize`, `show_team_lines` ← `ShowTeamLines`
- **Returns**: `FaxLineListResponse`
- **Error**: `ApiException<FaxLineListError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FaxLineListRequest` | `src/DropboxSignApi/Requests/FaxLine/FaxLineListRequest.cs` |
| `FaxLineListResponse` | `src/DropboxSignApi/Models/FaxLineListResponse.cs` |
| `FaxLineListError` | `src/DropboxSignApi/Errors/FaxLineListError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### FaxLineRemoveUser

- **Auth**: `options.ApiKey`
- **Signature**: `FaxLineRemoveUser(FaxLineRemoveUserOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `FaxLineResponse`
- **Error**: `ApiException<FaxLineRemoveUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FaxLineRemoveUserOperationRequest` | `src/DropboxSignApi/Requests/FaxLine/FaxLineRemoveUserOperationRequest.cs` |
| `FaxLineRemoveUserRequest` | `src/DropboxSignApi/Models/FaxLineRemoveUserRequest.cs` |
| `FaxLineResponse` | `src/DropboxSignApi/Models/FaxLineResponse.cs` |
| `FaxLineRemoveUserError` | `src/DropboxSignApi/Errors/FaxLineRemoveUserError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

