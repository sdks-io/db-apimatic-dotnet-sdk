<!-- Generated file — do not edit; regenerated with the SDK. -->

# Team — operations

Accessor: `client.Team` · Source: `src/DropboxSignApi/Api/Team.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### TeamAddMember

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TeamAddMember(TeamAddMemberOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Query params (wire ← C#)**: `team_id` ← `TeamId`
- **Returns**: `TeamGetResponse`
- **Error**: `ApiException<TeamAddMemberError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TeamAddMemberOperationRequest` | `src/DropboxSignApi/Requests/Team/TeamAddMemberOperationRequest.cs` |
| `TeamAddMemberRequest` | `src/DropboxSignApi/Models/TeamAddMemberRequest.cs` |
| `TeamGetResponse` | `src/DropboxSignApi/Models/TeamGetResponse.cs` |
| `TeamAddMemberError` | `src/DropboxSignApi/Errors/TeamAddMemberError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### TeamCreate

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TeamCreate(TeamCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TeamGetResponse`
- **Error**: `ApiException<TeamCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TeamCreateOperationRequest` | `src/DropboxSignApi/Requests/Team/TeamCreateOperationRequest.cs` |
| `TeamCreateRequest` | `src/DropboxSignApi/Models/TeamCreateRequest.cs` |
| `TeamGetResponse` | `src/DropboxSignApi/Models/TeamGetResponse.cs` |
| `TeamCreateError` | `src/DropboxSignApi/Errors/TeamCreateError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### TeamDelete

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TeamDelete(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `void` (Task)
- **Error**: `ApiException<TeamDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TeamDeleteError` | `src/DropboxSignApi/Errors/TeamDeleteError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### TeamGet

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TeamGet(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `TeamGetResponse`
- **Error**: `ApiException<TeamGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TeamGetResponse` | `src/DropboxSignApi/Models/TeamGetResponse.cs` |
| `TeamGetError` | `src/DropboxSignApi/Errors/TeamGetError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### TeamInfo

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TeamInfo(TeamInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `team_id` ← `TeamId`
- **Returns**: `TeamGetInfoResponse`
- **Error**: `ApiException<TeamInfoError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TeamInfoRequest` | `src/DropboxSignApi/Requests/Team/TeamInfoRequest.cs` |
| `TeamGetInfoResponse` | `src/DropboxSignApi/Models/TeamGetInfoResponse.cs` |
| `TeamInfoError` | `src/DropboxSignApi/Errors/TeamInfoError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### TeamInvites

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TeamInvites(TeamInvitesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `email_address` ← `EmailAddress`
- **Returns**: `TeamInvitesResponse`
- **Error**: `ApiException<TeamInvitesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TeamInvitesRequest` | `src/DropboxSignApi/Requests/Team/TeamInvitesRequest.cs` |
| `TeamInvitesResponse` | `src/DropboxSignApi/Models/TeamInvitesResponse.cs` |
| `TeamInvitesError` | `src/DropboxSignApi/Errors/TeamInvitesError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### TeamMembers

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TeamMembers(TeamMembersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TeamId`
- **Query params (wire ← C#)**: `page` ← `Page`, `page_size` ← `PageSize`
- **Returns**: `TeamMembersResponse`
- **Error**: `ApiException<TeamMembersError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TeamMembersRequest` | `src/DropboxSignApi/Requests/Team/TeamMembersRequest.cs` |
| `TeamMembersResponse` | `src/DropboxSignApi/Models/TeamMembersResponse.cs` |
| `TeamMembersError` | `src/DropboxSignApi/Errors/TeamMembersError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### TeamRemoveMember

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TeamRemoveMember(TeamRemoveMemberOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TeamGetResponse`
- **Error**: `ApiException<TeamRemoveMemberError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TeamRemoveMemberOperationRequest` | `src/DropboxSignApi/Requests/Team/TeamRemoveMemberOperationRequest.cs` |
| `TeamRemoveMemberRequest` | `src/DropboxSignApi/Models/TeamRemoveMemberRequest.cs` |
| `TeamGetResponse` | `src/DropboxSignApi/Models/TeamGetResponse.cs` |
| `TeamRemoveMemberError` | `src/DropboxSignApi/Errors/TeamRemoveMemberError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### TeamSubTeams

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TeamSubTeams(TeamSubTeamsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TeamId`
- **Query params (wire ← C#)**: `page` ← `Page`, `page_size` ← `PageSize`
- **Returns**: `TeamSubTeamsResponse`
- **Error**: `ApiException<TeamSubTeamsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TeamSubTeamsRequest` | `src/DropboxSignApi/Requests/Team/TeamSubTeamsRequest.cs` |
| `TeamSubTeamsResponse` | `src/DropboxSignApi/Models/TeamSubTeamsResponse.cs` |
| `TeamSubTeamsError` | `src/DropboxSignApi/Errors/TeamSubTeamsError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

### TeamUpdate

- **Auth**: `options.ApiKey` OR `options.Oauth2`
- **Signature**: `TeamUpdate(TeamUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TeamGetResponse`
- **Error**: `ApiException<TeamUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorResponseModel(out ErrorResponseModel)` [4XX] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TeamUpdateOperationRequest` | `src/DropboxSignApi/Requests/Team/TeamUpdateOperationRequest.cs` |
| `TeamUpdateRequest` | `src/DropboxSignApi/Models/TeamUpdateRequest.cs` |
| `TeamGetResponse` | `src/DropboxSignApi/Models/TeamGetResponse.cs` |
| `TeamUpdateError` | `src/DropboxSignApi/Errors/TeamUpdateError.cs` |
| `ErrorResponseModel` | `src/DropboxSignApi/Models/ErrorResponseModel.cs` |

