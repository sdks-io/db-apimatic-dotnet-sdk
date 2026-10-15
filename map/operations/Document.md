<!-- Generated file — do not edit; regenerated with the SDK. -->

# Document — operations

Accessor: `client.Document` · Source: `src/DropboxSignApi/Api/Document.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DocumentDetectFields

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `DocumentDetectFields(DocumentDetectFieldsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DetectionMode`
- **Returns**: `DocumentFieldDetectionResponse`
- **Error**: `ApiException<DocumentDetectFieldsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DocumentDetectFieldsRequest` | `src/DropboxSignApi/Requests/Document/DocumentDetectFieldsRequest.cs` |
| `DetectionMode` | `src/DropboxSignApi/Models/AnyOf/DetectionMode.cs` |
| `DocumentFieldDetectionResponse` | `src/DropboxSignApi/Models/DocumentFieldDetectionResponse.cs` |
| `DocumentDetectFieldsError` | `src/DropboxSignApi/Errors/DocumentDetectFieldsError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

