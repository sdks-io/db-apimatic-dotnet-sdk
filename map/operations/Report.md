<!-- Generated file — do not edit; regenerated with the SDK. -->

# Report — operations

Accessor: `client.Report` · Source: `src/DropboxSignApi/Api/Report.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ReportCreate

- **Auth**: `options.ApiKey`
- **Signature**: `ReportCreate(ReportCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ReportCreateResponse`
- **Error**: `ApiException<ReportCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReportCreateOperationRequest` | `src/DropboxSignApi/Requests/Report/ReportCreateOperationRequest.cs` |
| `ReportCreateRequest` | `src/DropboxSignApi/Models/ReportCreateRequest.cs` |
| `ReportCreateResponse` | `src/DropboxSignApi/Models/ReportCreateResponse.cs` |
| `ReportCreateError` | `src/DropboxSignApi/Errors/ReportCreateError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

