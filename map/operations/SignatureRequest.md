<!-- Generated file — do not edit; regenerated with the SDK. -->

# SignatureRequest — operations

Accessor: `client.SignatureRequest` · Source: `src/DropboxSignApi/Api/SignatureRequest.cs` · 20 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SignatureRequestBulkCreateEmbeddedWithTemplate

- **Auth**: `options.ApiKey`
- **Signature**: `SignatureRequestBulkCreateEmbeddedWithTemplate(SignatureRequestBulkCreateEmbeddedWithTemplateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TemplateIds`, `ClientId`
- **Returns**: `BulkSendJobSendResponse`
- **Error**: `ApiException<SignatureRequestBulkCreateEmbeddedWithTemplateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignatureRequestBulkCreateEmbeddedWithTemplateOperationRequest` | `src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestBulkCreateEmbeddedWithTemplateOperationRequest.cs` |
| `SubBulkSignerList` | `src/DropboxSignApi/Models/SubBulkSignerList.cs` |
| `SubCc` | `src/DropboxSignApi/Models/SubCc.cs` |
| `SubCustomField` | `src/DropboxSignApi/Models/SubCustomField.cs` |
| `BulkSendJobSendResponse` | `src/DropboxSignApi/Models/BulkSendJobSendResponse.cs` |
| `SignatureRequestBulkCreateEmbeddedWithTemplateError` | `src/DropboxSignApi/Errors/SignatureRequestBulkCreateEmbeddedWithTemplateError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### SignatureRequestBulkSendWithTemplate

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `SignatureRequestBulkSendWithTemplate(SignatureRequestBulkSendWithTemplateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TemplateIds`
- **Returns**: `BulkSendJobSendResponse`
- **Error**: `ApiException<SignatureRequestBulkSendWithTemplateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignatureRequestBulkSendWithTemplateOperationRequest` | `src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestBulkSendWithTemplateOperationRequest.cs` |
| `SubBulkSignerList` | `src/DropboxSignApi/Models/SubBulkSignerList.cs` |
| `SubCc` | `src/DropboxSignApi/Models/SubCc.cs` |
| `SubCustomField` | `src/DropboxSignApi/Models/SubCustomField.cs` |
| `BulkSendJobSendResponse` | `src/DropboxSignApi/Models/BulkSendJobSendResponse.cs` |
| `SignatureRequestBulkSendWithTemplateError` | `src/DropboxSignApi/Errors/SignatureRequestBulkSendWithTemplateError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### SignatureRequestCancel

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `SignatureRequestCancel(SignatureRequestCancelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SignatureRequestId`
- **Returns**: `object`
- **Error**: `ApiException<SignatureRequestCancelError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignatureRequestCancelRequest` | `src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestCancelRequest.cs` |
| `SignatureRequestCancelError` | `src/DropboxSignApi/Errors/SignatureRequestCancelError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### SignatureRequestCreateEmbedded

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `SignatureRequestCreateEmbedded(SignatureRequestCreateEmbeddedOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClientId`
- **Returns**: `SignatureRequestGetResponse`
- **Error**: `ApiException<SignatureRequestCreateEmbeddedError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignatureRequestCreateEmbeddedOperationRequest` | `src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestCreateEmbeddedOperationRequest.cs` |
| `SubSignatureRequestSigner` | `src/DropboxSignApi/Models/SubSignatureRequestSigner.cs` |
| `SubSignatureRequestGroupedSigners` | `src/DropboxSignApi/Models/SubSignatureRequestGroupedSigners.cs` |
| `SubAttachment` | `src/DropboxSignApi/Models/SubAttachment.cs` |
| `SubCustomField` | `src/DropboxSignApi/Models/SubCustomField.cs` |
| `SubFieldOptions` | `src/DropboxSignApi/Models/SubFieldOptions.cs` |
| `SubFormFieldGroup` | `src/DropboxSignApi/Models/SubFormFieldGroup.cs` |
| `SubFormFieldRule` | `src/DropboxSignApi/Models/SubFormFieldRule.cs` |
| `SubFormFieldsPerDocumentBase` | `src/DropboxSignApi/Models/SubFormFieldsPerDocumentBase.cs` |
| `SubSigningOptions` | `src/DropboxSignApi/Models/SubSigningOptions.cs` |
| `SignatureRequestGetResponse` | `src/DropboxSignApi/Models/SignatureRequestGetResponse.cs` |
| `SignatureRequestCreateEmbeddedError` | `src/DropboxSignApi/Errors/SignatureRequestCreateEmbeddedError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### SignatureRequestCreateEmbeddedWithTemplate

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `SignatureRequestCreateEmbeddedWithTemplate(SignatureRequestCreateEmbeddedWithTemplateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TemplateIds`, `ClientId`, `Signers`
- **Returns**: `SignatureRequestGetResponse`
- **Error**: `ApiException<SignatureRequestCreateEmbeddedWithTemplateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignatureRequestCreateEmbeddedWithTemplateOperationRequest` | `src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestCreateEmbeddedWithTemplateOperationRequest.cs` |
| `SubSignatureRequestTemplateSigner` | `src/DropboxSignApi/Models/SubSignatureRequestTemplateSigner.cs` |
| `SubCc` | `src/DropboxSignApi/Models/SubCc.cs` |
| `SubCustomField` | `src/DropboxSignApi/Models/SubCustomField.cs` |
| `SubSigningOptions` | `src/DropboxSignApi/Models/SubSigningOptions.cs` |
| `SignatureRequestGetResponse` | `src/DropboxSignApi/Models/SignatureRequestGetResponse.cs` |
| `SignatureRequestCreateEmbeddedWithTemplateError` | `src/DropboxSignApi/Errors/SignatureRequestCreateEmbeddedWithTemplateError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### SignatureRequestEdit

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `SignatureRequestEdit(SignatureRequestEditOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SignatureRequestId`
- **Returns**: `SignatureRequestGetResponse`
- **Error**: `ApiException<SignatureRequestEditError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignatureRequestEditOperationRequest` | `src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestEditOperationRequest.cs` |
| `SubSignatureRequestSigner` | `src/DropboxSignApi/Models/SubSignatureRequestSigner.cs` |
| `SubSignatureRequestGroupedSigners` | `src/DropboxSignApi/Models/SubSignatureRequestGroupedSigners.cs` |
| `SubAttachment` | `src/DropboxSignApi/Models/SubAttachment.cs` |
| `SubCustomField` | `src/DropboxSignApi/Models/SubCustomField.cs` |
| `SubFieldOptions` | `src/DropboxSignApi/Models/SubFieldOptions.cs` |
| `SubFormFieldGroup` | `src/DropboxSignApi/Models/SubFormFieldGroup.cs` |
| `SubFormFieldRule` | `src/DropboxSignApi/Models/SubFormFieldRule.cs` |
| `SubFormFieldsPerDocumentBase` | `src/DropboxSignApi/Models/SubFormFieldsPerDocumentBase.cs` |
| `SubSigningOptions` | `src/DropboxSignApi/Models/SubSigningOptions.cs` |
| `SignatureRequestGetResponse` | `src/DropboxSignApi/Models/SignatureRequestGetResponse.cs` |
| `SignatureRequestEditError` | `src/DropboxSignApi/Errors/SignatureRequestEditError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### SignatureRequestEditEmbedded

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `SignatureRequestEditEmbedded(SignatureRequestEditEmbeddedOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SignatureRequestId`, `ClientId`
- **Returns**: `SignatureRequestGetResponse`
- **Error**: `ApiException<SignatureRequestEditEmbeddedError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignatureRequestEditEmbeddedOperationRequest` | `src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestEditEmbeddedOperationRequest.cs` |
| `SubSignatureRequestSigner` | `src/DropboxSignApi/Models/SubSignatureRequestSigner.cs` |
| `SubSignatureRequestGroupedSigners` | `src/DropboxSignApi/Models/SubSignatureRequestGroupedSigners.cs` |
| `SubAttachment` | `src/DropboxSignApi/Models/SubAttachment.cs` |
| `SubCustomField` | `src/DropboxSignApi/Models/SubCustomField.cs` |
| `SubFieldOptions` | `src/DropboxSignApi/Models/SubFieldOptions.cs` |
| `SubFormFieldGroup` | `src/DropboxSignApi/Models/SubFormFieldGroup.cs` |
| `SubFormFieldRule` | `src/DropboxSignApi/Models/SubFormFieldRule.cs` |
| `SubFormFieldsPerDocumentBase` | `src/DropboxSignApi/Models/SubFormFieldsPerDocumentBase.cs` |
| `SubSigningOptions` | `src/DropboxSignApi/Models/SubSigningOptions.cs` |
| `SignatureRequestGetResponse` | `src/DropboxSignApi/Models/SignatureRequestGetResponse.cs` |
| `SignatureRequestEditEmbeddedError` | `src/DropboxSignApi/Errors/SignatureRequestEditEmbeddedError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### SignatureRequestEditEmbeddedWithTemplate

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `SignatureRequestEditEmbeddedWithTemplate(SignatureRequestEditEmbeddedWithTemplateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SignatureRequestId`, `TemplateIds`, `ClientId`, `Signers`
- **Returns**: `SignatureRequestGetResponse`
- **Error**: `ApiException<SignatureRequestEditEmbeddedWithTemplateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignatureRequestEditEmbeddedWithTemplateOperationRequest` | `src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestEditEmbeddedWithTemplateOperationRequest.cs` |
| `SubSignatureRequestTemplateSigner` | `src/DropboxSignApi/Models/SubSignatureRequestTemplateSigner.cs` |
| `SubCc` | `src/DropboxSignApi/Models/SubCc.cs` |
| `SubCustomField` | `src/DropboxSignApi/Models/SubCustomField.cs` |
| `SubSigningOptions` | `src/DropboxSignApi/Models/SubSigningOptions.cs` |
| `SignatureRequestGetResponse` | `src/DropboxSignApi/Models/SignatureRequestGetResponse.cs` |
| `SignatureRequestEditEmbeddedWithTemplateError` | `src/DropboxSignApi/Errors/SignatureRequestEditEmbeddedWithTemplateError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### SignatureRequestEditWithTemplate

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `SignatureRequestEditWithTemplate(SignatureRequestEditWithTemplateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SignatureRequestId`, `TemplateIds`, `Signers`
- **Returns**: `SignatureRequestGetResponse`
- **Error**: `ApiException<SignatureRequestEditWithTemplateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignatureRequestEditWithTemplateOperationRequest` | `src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestEditWithTemplateOperationRequest.cs` |
| `SubSignatureRequestTemplateSigner` | `src/DropboxSignApi/Models/SubSignatureRequestTemplateSigner.cs` |
| `SubCc` | `src/DropboxSignApi/Models/SubCc.cs` |
| `SubCustomField` | `src/DropboxSignApi/Models/SubCustomField.cs` |
| `SubSigningOptions` | `src/DropboxSignApi/Models/SubSigningOptions.cs` |
| `SignatureRequestGetResponse` | `src/DropboxSignApi/Models/SignatureRequestGetResponse.cs` |
| `SignatureRequestEditWithTemplateError` | `src/DropboxSignApi/Errors/SignatureRequestEditWithTemplateError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### SignatureRequestFiles

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `SignatureRequestFiles(SignatureRequestFilesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SignatureRequestId`
- **Query params (wire ← C#)**: `file_type` ← `FileType`
- **Returns**: `void` (Task)
- **Error**: `ApiException<SignatureRequestFilesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignatureRequestFilesRequest` | `src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestFilesRequest.cs` |
| `FileType` | `src/DropboxSignApi/Models/Enums/FileType.cs` |
| `SignatureRequestFilesError` | `src/DropboxSignApi/Errors/SignatureRequestFilesError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### SignatureRequestFilesAsDataUri

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `SignatureRequestFilesAsDataUri(SignatureRequestFilesAsDataUriRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SignatureRequestId`
- **Returns**: `FileResponseDataUri`
- **Error**: `ApiException<SignatureRequestFilesAsDataUriError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignatureRequestFilesAsDataUriRequest` | `src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestFilesAsDataUriRequest.cs` |
| `FileResponseDataUri` | `src/DropboxSignApi/Models/FileResponseDataUri.cs` |
| `SignatureRequestFilesAsDataUriError` | `src/DropboxSignApi/Errors/SignatureRequestFilesAsDataUriError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### SignatureRequestFilesAsFileUrl

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `SignatureRequestFilesAsFileUrl(SignatureRequestFilesAsFileUrlRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SignatureRequestId`
- **Query params (wire ← C#)**: `force_download` ← `ForceDownload`
- **Returns**: `FileResponse`
- **Error**: `ApiException<SignatureRequestFilesAsFileUrlError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignatureRequestFilesAsFileUrlRequest` | `src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestFilesAsFileUrlRequest.cs` |
| `FileResponse` | `src/DropboxSignApi/Models/FileResponse.cs` |
| `SignatureRequestFilesAsFileUrlError` | `src/DropboxSignApi/Errors/SignatureRequestFilesAsFileUrlError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### SignatureRequestGet

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `SignatureRequestGet(SignatureRequestGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SignatureRequestId`
- **Returns**: `SignatureRequestGetResponse`
- **Error**: `ApiException<SignatureRequestGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignatureRequestGetRequest` | `src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestGetRequest.cs` |
| `SignatureRequestGetResponse` | `src/DropboxSignApi/Models/SignatureRequestGetResponse.cs` |
| `SignatureRequestGetError` | `src/DropboxSignApi/Errors/SignatureRequestGetError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### SignatureRequestList

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `SignatureRequestList(SignatureRequestListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `account_id` ← `AccountId`, `page` ← `Page`, `page_size` ← `PageSize`, `query` ← `Query`
- **Returns**: `SignatureRequestListResponse`
- **Error**: `ApiException<SignatureRequestListError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignatureRequestListRequest` | `src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestListRequest.cs` |
| `SignatureRequestListResponse` | `src/DropboxSignApi/Models/SignatureRequestListResponse.cs` |
| `SignatureRequestListError` | `src/DropboxSignApi/Errors/SignatureRequestListError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### SignatureRequestReleaseHold

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `SignatureRequestReleaseHold(SignatureRequestReleaseHoldRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SignatureRequestId`
- **Returns**: `SignatureRequestGetResponse`
- **Error**: `ApiException<SignatureRequestReleaseHoldError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignatureRequestReleaseHoldRequest` | `src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestReleaseHoldRequest.cs` |
| `SignatureRequestGetResponse` | `src/DropboxSignApi/Models/SignatureRequestGetResponse.cs` |
| `SignatureRequestReleaseHoldError` | `src/DropboxSignApi/Errors/SignatureRequestReleaseHoldError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### SignatureRequestRemind

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `SignatureRequestRemind(SignatureRequestRemindOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SignatureRequestId`, `Body`
- **Returns**: `SignatureRequestGetResponse`
- **Error**: `ApiException<SignatureRequestRemindError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignatureRequestRemindOperationRequest` | `src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestRemindOperationRequest.cs` |
| `SignatureRequestRemindRequest` | `src/DropboxSignApi/Models/SignatureRequestRemindRequest.cs` |
| `SignatureRequestGetResponse` | `src/DropboxSignApi/Models/SignatureRequestGetResponse.cs` |
| `SignatureRequestRemindError` | `src/DropboxSignApi/Errors/SignatureRequestRemindError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### SignatureRequestRemove

- **Auth**: `options.ApiKey`
- **Signature**: `SignatureRequestRemove(SignatureRequestRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SignatureRequestId`
- **Returns**: `object`
- **Error**: `ApiException<SignatureRequestRemoveError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignatureRequestRemoveRequest` | `src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestRemoveRequest.cs` |
| `SignatureRequestRemoveError` | `src/DropboxSignApi/Errors/SignatureRequestRemoveError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### SignatureRequestSend

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `SignatureRequestSend(SignatureRequestSendOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SignatureRequestGetResponse`
- **Error**: `ApiException<SignatureRequestSendError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignatureRequestSendOperationRequest` | `src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestSendOperationRequest.cs` |
| `SubSignatureRequestSigner` | `src/DropboxSignApi/Models/SubSignatureRequestSigner.cs` |
| `SubSignatureRequestGroupedSigners` | `src/DropboxSignApi/Models/SubSignatureRequestGroupedSigners.cs` |
| `SubAttachment` | `src/DropboxSignApi/Models/SubAttachment.cs` |
| `SubCustomField` | `src/DropboxSignApi/Models/SubCustomField.cs` |
| `SubFieldOptions` | `src/DropboxSignApi/Models/SubFieldOptions.cs` |
| `SubFormFieldGroup` | `src/DropboxSignApi/Models/SubFormFieldGroup.cs` |
| `SubFormFieldRule` | `src/DropboxSignApi/Models/SubFormFieldRule.cs` |
| `SubFormFieldsPerDocumentBase` | `src/DropboxSignApi/Models/SubFormFieldsPerDocumentBase.cs` |
| `SubSigningOptions` | `src/DropboxSignApi/Models/SubSigningOptions.cs` |
| `SignatureRequestGetResponse` | `src/DropboxSignApi/Models/SignatureRequestGetResponse.cs` |
| `SignatureRequestSendError` | `src/DropboxSignApi/Errors/SignatureRequestSendError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### SignatureRequestSendWithTemplate

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `SignatureRequestSendWithTemplate(SignatureRequestSendWithTemplateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TemplateIds`, `Signers`
- **Returns**: `SignatureRequestGetResponse`
- **Error**: `ApiException<SignatureRequestSendWithTemplateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignatureRequestSendWithTemplateOperationRequest` | `src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestSendWithTemplateOperationRequest.cs` |
| `SubSignatureRequestTemplateSigner` | `src/DropboxSignApi/Models/SubSignatureRequestTemplateSigner.cs` |
| `SubCc` | `src/DropboxSignApi/Models/SubCc.cs` |
| `SubCustomField` | `src/DropboxSignApi/Models/SubCustomField.cs` |
| `SubSigningOptions` | `src/DropboxSignApi/Models/SubSigningOptions.cs` |
| `SignatureRequestGetResponse` | `src/DropboxSignApi/Models/SignatureRequestGetResponse.cs` |
| `SignatureRequestSendWithTemplateError` | `src/DropboxSignApi/Errors/SignatureRequestSendWithTemplateError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### SignatureRequestUpdate

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `SignatureRequestUpdate(SignatureRequestUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SignatureRequestId`, `Body`
- **Returns**: `SignatureRequestGetResponse`
- **Error**: `ApiException<SignatureRequestUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignatureRequestUpdateOperationRequest` | `src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestUpdateOperationRequest.cs` |
| `SignatureRequestUpdateRequest` | `src/DropboxSignApi/Models/SignatureRequestUpdateRequest.cs` |
| `SignatureRequestGetResponse` | `src/DropboxSignApi/Models/SignatureRequestGetResponse.cs` |
| `SignatureRequestUpdateError` | `src/DropboxSignApi/Errors/SignatureRequestUpdateError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

