<!-- Generated file — do not edit; regenerated with the SDK. -->

# UnclaimedDraft — operations

Accessor: `client.UnclaimedDraft` · Source: `src/DropboxSignApi/Api/UnclaimedDraft.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### UnclaimedDraftCreate

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `UnclaimedDraftCreate(UnclaimedDraftCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Type`
- **Returns**: `UnclaimedDraftCreateResponse`
- **Error**: `ApiException<UnclaimedDraftCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UnclaimedDraftCreateOperationRequest` | `src/DropboxSignApi/Requests/UnclaimedDraft/UnclaimedDraftCreateOperationRequest.cs` |
| `Type2` | `src/DropboxSignApi/Models/Enums/Type2.cs` |
| `SubAttachment` | `src/DropboxSignApi/Models/SubAttachment.cs` |
| `SubCustomField` | `src/DropboxSignApi/Models/SubCustomField.cs` |
| `SubFieldOptions` | `src/DropboxSignApi/Models/SubFieldOptions.cs` |
| `SubFormFieldGroup` | `src/DropboxSignApi/Models/SubFormFieldGroup.cs` |
| `SubFormFieldRule` | `src/DropboxSignApi/Models/SubFormFieldRule.cs` |
| `SubFormFieldsPerDocumentBase` | `src/DropboxSignApi/Models/SubFormFieldsPerDocumentBase.cs` |
| `SubUnclaimedDraftSigner` | `src/DropboxSignApi/Models/SubUnclaimedDraftSigner.cs` |
| `SubSigningOptions` | `src/DropboxSignApi/Models/SubSigningOptions.cs` |
| `UnclaimedDraftCreateResponse` | `src/DropboxSignApi/Models/UnclaimedDraftCreateResponse.cs` |
| `UnclaimedDraftCreateError` | `src/DropboxSignApi/Errors/UnclaimedDraftCreateError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### UnclaimedDraftCreateEmbedded

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `UnclaimedDraftCreateEmbedded(UnclaimedDraftCreateEmbeddedOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClientId`, `RequesterEmailAddress`
- **Returns**: `UnclaimedDraftCreateResponse`
- **Error**: `ApiException<UnclaimedDraftCreateEmbeddedError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UnclaimedDraftCreateEmbeddedOperationRequest` | `src/DropboxSignApi/Requests/UnclaimedDraft/UnclaimedDraftCreateEmbeddedOperationRequest.cs` |
| `SubAttachment` | `src/DropboxSignApi/Models/SubAttachment.cs` |
| `SubCustomField` | `src/DropboxSignApi/Models/SubCustomField.cs` |
| `SubEditorOptions` | `src/DropboxSignApi/Models/SubEditorOptions.cs` |
| `SubFieldOptions` | `src/DropboxSignApi/Models/SubFieldOptions.cs` |
| `SubFormFieldGroup` | `src/DropboxSignApi/Models/SubFormFieldGroup.cs` |
| `SubFormFieldRule` | `src/DropboxSignApi/Models/SubFormFieldRule.cs` |
| `SubFormFieldsPerDocumentBase` | `src/DropboxSignApi/Models/SubFormFieldsPerDocumentBase.cs` |
| `SubUnclaimedDraftSigner` | `src/DropboxSignApi/Models/SubUnclaimedDraftSigner.cs` |
| `SubSigningOptions` | `src/DropboxSignApi/Models/SubSigningOptions.cs` |
| `Type3` | `src/DropboxSignApi/Models/Enums/Type3.cs` |
| `UnclaimedDraftCreateResponse` | `src/DropboxSignApi/Models/UnclaimedDraftCreateResponse.cs` |
| `UnclaimedDraftCreateEmbeddedError` | `src/DropboxSignApi/Errors/UnclaimedDraftCreateEmbeddedError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### UnclaimedDraftCreateEmbeddedWithTemplate

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `UnclaimedDraftCreateEmbeddedWithTemplate(UnclaimedDraftCreateEmbeddedWithTemplateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClientId`, `RequesterEmailAddress`, `TemplateIds`
- **Returns**: `UnclaimedDraftCreateResponse`
- **Error**: `ApiException<UnclaimedDraftCreateEmbeddedWithTemplateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UnclaimedDraftCreateEmbeddedWithTemplateOperationRequest` | `src/DropboxSignApi/Requests/UnclaimedDraft/UnclaimedDraftCreateEmbeddedWithTemplateOperationRequest.cs` |
| `SubCc` | `src/DropboxSignApi/Models/SubCc.cs` |
| `SubCustomField` | `src/DropboxSignApi/Models/SubCustomField.cs` |
| `SubEditorOptions` | `src/DropboxSignApi/Models/SubEditorOptions.cs` |
| `SubFieldOptions` | `src/DropboxSignApi/Models/SubFieldOptions.cs` |
| `SubUnclaimedDraftTemplateSigner` | `src/DropboxSignApi/Models/SubUnclaimedDraftTemplateSigner.cs` |
| `SubSigningOptions` | `src/DropboxSignApi/Models/SubSigningOptions.cs` |
| `UnclaimedDraftCreateResponse` | `src/DropboxSignApi/Models/UnclaimedDraftCreateResponse.cs` |
| `UnclaimedDraftCreateEmbeddedWithTemplateError` | `src/DropboxSignApi/Errors/UnclaimedDraftCreateEmbeddedWithTemplateError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### UnclaimedDraftEditAndResend

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `UnclaimedDraftEditAndResend(UnclaimedDraftEditAndResendOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SignatureRequestId`, `Body`
- **Returns**: `UnclaimedDraftCreateResponse`
- **Error**: `ApiException<UnclaimedDraftEditAndResendError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UnclaimedDraftEditAndResendOperationRequest` | `src/DropboxSignApi/Requests/UnclaimedDraft/UnclaimedDraftEditAndResendOperationRequest.cs` |
| `UnclaimedDraftEditAndResendRequest` | `src/DropboxSignApi/Models/UnclaimedDraftEditAndResendRequest.cs` |
| `UnclaimedDraftCreateResponse` | `src/DropboxSignApi/Models/UnclaimedDraftCreateResponse.cs` |
| `UnclaimedDraftEditAndResendError` | `src/DropboxSignApi/Errors/UnclaimedDraftEditAndResendError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

