<!-- Generated file — do not edit; regenerated with the SDK. -->

# Template — operations

Accessor: `client.Template` · Source: `src/DropboxSignApi/Api/Template.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### TemplateAddUser

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TemplateAddUser(TemplateAddUserOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TemplateId`, `Body`
- **Returns**: `TemplateGetResponse`
- **Error**: `ApiException<TemplateAddUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TemplateAddUserOperationRequest` | `src/DropboxSignApi/Requests/Template/TemplateAddUserOperationRequest.cs` |
| `TemplateAddUserRequest` | `src/DropboxSignApi/Models/TemplateAddUserRequest.cs` |
| `TemplateGetResponse` | `src/DropboxSignApi/Models/TemplateGetResponse.cs` |
| `TemplateAddUserError` | `src/DropboxSignApi/Errors/TemplateAddUserError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### TemplateCreate

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TemplateCreate(TemplateCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `FormFieldsPerDocument`, `SignerRoles`
- **Returns**: `TemplateCreateResponse`
- **Error**: `ApiException<TemplateCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TemplateCreateOperationRequest` | `src/DropboxSignApi/Requests/Template/TemplateCreateOperationRequest.cs` |
| `SubFormFieldsPerDocumentBase` | `src/DropboxSignApi/Models/SubFormFieldsPerDocumentBase.cs` |
| `SubTemplateRole` | `src/DropboxSignApi/Models/SubTemplateRole.cs` |
| `SubAttachment` | `src/DropboxSignApi/Models/SubAttachment.cs` |
| `SubFieldOptions` | `src/DropboxSignApi/Models/SubFieldOptions.cs` |
| `SubFormFieldGroup` | `src/DropboxSignApi/Models/SubFormFieldGroup.cs` |
| `SubFormFieldRule` | `src/DropboxSignApi/Models/SubFormFieldRule.cs` |
| `SubMergeField` | `src/DropboxSignApi/Models/SubMergeField.cs` |
| `TemplateCreateResponse` | `src/DropboxSignApi/Models/TemplateCreateResponse.cs` |
| `TemplateCreateError` | `src/DropboxSignApi/Errors/TemplateCreateError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### TemplateCreateEmbeddedDraft

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TemplateCreateEmbeddedDraft(TemplateCreateEmbeddedDraftOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClientId`
- **Returns**: `TemplateCreateEmbeddedDraftResponse`
- **Error**: `ApiException<TemplateCreateEmbeddedDraftError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TemplateCreateEmbeddedDraftOperationRequest` | `src/DropboxSignApi/Requests/Template/TemplateCreateEmbeddedDraftOperationRequest.cs` |
| `SubAttachment` | `src/DropboxSignApi/Models/SubAttachment.cs` |
| `SubEditorOptions` | `src/DropboxSignApi/Models/SubEditorOptions.cs` |
| `SubFieldOptions` | `src/DropboxSignApi/Models/SubFieldOptions.cs` |
| `SubFormFieldGroup` | `src/DropboxSignApi/Models/SubFormFieldGroup.cs` |
| `SubFormFieldRule` | `src/DropboxSignApi/Models/SubFormFieldRule.cs` |
| `SubFormFieldsPerDocumentBase` | `src/DropboxSignApi/Models/SubFormFieldsPerDocumentBase.cs` |
| `SubMergeField` | `src/DropboxSignApi/Models/SubMergeField.cs` |
| `SubTemplateRole` | `src/DropboxSignApi/Models/SubTemplateRole.cs` |
| `TemplateCreateEmbeddedDraftResponse` | `src/DropboxSignApi/Models/TemplateCreateEmbeddedDraftResponse.cs` |
| `TemplateCreateEmbeddedDraftError` | `src/DropboxSignApi/Errors/TemplateCreateEmbeddedDraftError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### TemplateDelete

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TemplateDelete(TemplateDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TemplateId`
- **Returns**: `object`
- **Error**: `ApiException<TemplateDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TemplateDeleteRequest` | `src/DropboxSignApi/Requests/Template/TemplateDeleteRequest.cs` |
| `TemplateDeleteError` | `src/DropboxSignApi/Errors/TemplateDeleteError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### TemplateFiles

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TemplateFiles(TemplateFilesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TemplateId`
- **Query params (wire ← C#)**: `file_type` ← `FileType`
- **Returns**: `void` (Task)
- **Error**: `ApiException<TemplateFilesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TemplateFilesRequest` | `src/DropboxSignApi/Requests/Template/TemplateFilesRequest.cs` |
| `FileType` | `src/DropboxSignApi/Models/Enums/FileType.cs` |
| `TemplateFilesError` | `src/DropboxSignApi/Errors/TemplateFilesError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### TemplateFilesAsDataUri

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TemplateFilesAsDataUri(TemplateFilesAsDataUriRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TemplateId`
- **Returns**: `FileResponseDataUri`
- **Error**: `ApiException<TemplateFilesAsDataUriError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TemplateFilesAsDataUriRequest` | `src/DropboxSignApi/Requests/Template/TemplateFilesAsDataUriRequest.cs` |
| `FileResponseDataUri` | `src/DropboxSignApi/Models/FileResponseDataUri.cs` |
| `TemplateFilesAsDataUriError` | `src/DropboxSignApi/Errors/TemplateFilesAsDataUriError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### TemplateFilesAsFileUrl

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TemplateFilesAsFileUrl(TemplateFilesAsFileUrlRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TemplateId`
- **Query params (wire ← C#)**: `force_download` ← `ForceDownload`
- **Returns**: `FileResponse`
- **Error**: `ApiException<TemplateFilesAsFileUrlError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TemplateFilesAsFileUrlRequest` | `src/DropboxSignApi/Requests/Template/TemplateFilesAsFileUrlRequest.cs` |
| `FileResponse` | `src/DropboxSignApi/Models/FileResponse.cs` |
| `TemplateFilesAsFileUrlError` | `src/DropboxSignApi/Errors/TemplateFilesAsFileUrlError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### TemplateGet

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TemplateGet(TemplateGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TemplateId`
- **Returns**: `TemplateGetResponse`
- **Error**: `ApiException<TemplateGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TemplateGetRequest` | `src/DropboxSignApi/Requests/Template/TemplateGetRequest.cs` |
| `TemplateGetResponse` | `src/DropboxSignApi/Models/TemplateGetResponse.cs` |
| `TemplateGetError` | `src/DropboxSignApi/Errors/TemplateGetError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### TemplateList

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TemplateList(TemplateListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `account_id` ← `AccountId`, `page` ← `Page`, `page_size` ← `PageSize`, `query` ← `Query`
- **Returns**: `TemplateListResponse`
- **Error**: `ApiException<TemplateListError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TemplateListRequest` | `src/DropboxSignApi/Requests/Template/TemplateListRequest.cs` |
| `TemplateListResponse` | `src/DropboxSignApi/Models/TemplateListResponse.cs` |
| `TemplateListError` | `src/DropboxSignApi/Errors/TemplateListError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### TemplateRemoveUser

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TemplateRemoveUser(TemplateRemoveUserOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TemplateId`, `Body`
- **Returns**: `TemplateGetResponse`
- **Error**: `ApiException<TemplateRemoveUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TemplateRemoveUserOperationRequest` | `src/DropboxSignApi/Requests/Template/TemplateRemoveUserOperationRequest.cs` |
| `TemplateRemoveUserRequest` | `src/DropboxSignApi/Models/TemplateRemoveUserRequest.cs` |
| `TemplateGetResponse` | `src/DropboxSignApi/Models/TemplateGetResponse.cs` |
| `TemplateRemoveUserError` | `src/DropboxSignApi/Errors/TemplateRemoveUserError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### TemplateUpdateFiles

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TemplateUpdateFiles(TemplateUpdateFilesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TemplateId`
- **Returns**: `TemplateUpdateFilesResponse`
- **Error**: `ApiException<TemplateUpdateFilesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TemplateUpdateFilesOperationRequest` | `src/DropboxSignApi/Requests/Template/TemplateUpdateFilesOperationRequest.cs` |
| `TemplateUpdateFilesResponse` | `src/DropboxSignApi/Models/TemplateUpdateFilesResponse.cs` |
| `TemplateUpdateFilesError` | `src/DropboxSignApi/Errors/TemplateUpdateFilesError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

