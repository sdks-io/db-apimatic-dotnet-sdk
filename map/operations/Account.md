<!-- Generated file — do not edit; regenerated with the SDK. -->

# Account — operations

Accessor: `client.Account` · Source: `src/DropboxSignApi/Api/Account.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AccountCreate

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `AccountCreate(AccountCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AccountCreateResponse`
- **Error**: `ApiException<AccountCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AccountCreateOperationRequest` | `src/DropboxSignApi/Requests/Account/AccountCreateOperationRequest.cs` |
| `AccountCreateRequest` | `src/DropboxSignApi/Models/AccountCreateRequest.cs` |
| `AccountCreateResponse` | `src/DropboxSignApi/Models/AccountCreateResponse.cs` |
| `AccountCreateError` | `src/DropboxSignApi/Errors/AccountCreateError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### AccountGet

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `AccountGet(AccountGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `account_id` ← `AccountId`, `email_address` ← `EmailAddress`
- **Returns**: `AccountGetResponse`
- **Error**: `ApiException<AccountGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AccountGetRequest` | `src/DropboxSignApi/Requests/Account/AccountGetRequest.cs` |
| `AccountGetResponse` | `src/DropboxSignApi/Models/AccountGetResponse.cs` |
| `AccountGetError` | `src/DropboxSignApi/Errors/AccountGetError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### AccountUpdate

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `AccountUpdate(AccountUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AccountGetResponse`
- **Error**: `ApiException<AccountUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AccountUpdateOperationRequest` | `src/DropboxSignApi/Requests/Account/AccountUpdateOperationRequest.cs` |
| `AccountUpdateRequest` | `src/DropboxSignApi/Models/AccountUpdateRequest.cs` |
| `AccountGetResponse` | `src/DropboxSignApi/Models/AccountGetResponse.cs` |
| `AccountUpdateError` | `src/DropboxSignApi/Errors/AccountUpdateError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### AccountVerify

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `AccountVerify(AccountVerifyOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AccountVerifyResponse`
- **Error**: `ApiException<AccountVerifyError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AccountVerifyOperationRequest` | `src/DropboxSignApi/Requests/Account/AccountVerifyOperationRequest.cs` |
| `AccountVerifyRequest` | `src/DropboxSignApi/Models/AccountVerifyRequest.cs` |
| `AccountVerifyResponse` | `src/DropboxSignApi/Models/AccountVerifyResponse.cs` |
| `AccountVerifyError` | `src/DropboxSignApi/Errors/AccountVerifyError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

