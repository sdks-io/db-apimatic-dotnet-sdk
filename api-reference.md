# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a credential that cannot be applied as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [DropboxSignApiClient](src/DropboxSignApi/DropboxSignApiClient.cs)

## Account

> Source: [Account](src/DropboxSignApi/Api/Account.cs)

<details>
<summary><code>Task&lt;AccountCreateResponse&gt; AccountCreate(AccountCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new Dropbox Sign Account that is associated with the specified `email_address`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Account.AccountCreate(new AccountCreateOperationRequest
    {
        Body = new AccountCreateRequest { EmailAddress = "user@example.com" },
    });
    // TODO: Handle 'response' of type AccountCreateResponse
}
catch (ApiException<AccountCreateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AccountCreateOperationRequest](src/DropboxSignApi/Requests/Account/AccountCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountCreateResponse](src/DropboxSignApi/Models/AccountCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[AccountCreateError](src/DropboxSignApi/Errors/AccountCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountGetResponse&gt; AccountGet(AccountGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the properties and settings of your Account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Account.AccountGet(new AccountGetRequest());
    // TODO: Handle 'response' of type AccountGetResponse
}
catch (ApiException<AccountGetError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AccountGetRequest](src/DropboxSignApi/Requests/Account/AccountGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountGetResponse](src/DropboxSignApi/Models/AccountGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[AccountGetError](src/DropboxSignApi/Errors/AccountGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountGetResponse&gt; AccountUpdate(AccountUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the properties and settings of your Account. Currently only allows for updates to the [Callback URL](/api/reference/tag/Callbacks-and-Events) and locale.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Account.AccountUpdate(new AccountUpdateOperationRequest
    {
        Body = new AccountUpdateRequest(),
    });
    // TODO: Handle 'response' of type AccountGetResponse
}
catch (ApiException<AccountUpdateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AccountUpdateOperationRequest](src/DropboxSignApi/Requests/Account/AccountUpdateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountGetResponse](src/DropboxSignApi/Models/AccountGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[AccountUpdateError](src/DropboxSignApi/Errors/AccountUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountVerifyResponse&gt; AccountVerify(AccountVerifyOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Verifies whether an Dropbox Sign Account exists for the given email address.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Account.AccountVerify(new AccountVerifyOperationRequest
    {
        Body = new AccountVerifyRequest { EmailAddress = "user@example.com" },
    });
    // TODO: Handle 'response' of type AccountVerifyResponse
}
catch (ApiException<AccountVerifyError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AccountVerifyOperationRequest](src/DropboxSignApi/Requests/Account/AccountVerifyOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountVerifyResponse](src/DropboxSignApi/Models/AccountVerifyResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[AccountVerifyError](src/DropboxSignApi/Errors/AccountVerifyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ApiApp

> Source: [ApiApp](src/DropboxSignApi/Api/ApiApp.cs)

<details>
<summary><code>Task&lt;ApiAppGetResponse&gt; ApiAppCreate(ApiAppCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new API App.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiApp.ApiAppCreate(new ApiAppCreateOperationRequest
    {
        Domains = ["some example string"],
        Name = "some example string",
    });
    // TODO: Handle 'response' of type ApiAppGetResponse
}
catch (ApiException<ApiAppCreateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ApiAppCreateOperationRequest](src/DropboxSignApi/Requests/ApiApp/ApiAppCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiAppGetResponse](src/DropboxSignApi/Models/ApiAppGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[ApiAppCreateError](src/DropboxSignApi/Errors/ApiAppCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task ApiAppDelete(ApiAppDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes an API App. Can only be invoked for apps you own.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ApiApp.ApiAppDelete(new ApiAppDeleteRequest { ClientId = "0dd3b823a682527788c4e40cb7b6f7e9" });
}
catch (ApiException<ApiAppDeleteError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ApiAppDeleteRequest](src/DropboxSignApi/Requests/ApiApp/ApiAppDeleteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[ApiAppDeleteError](src/DropboxSignApi/Errors/ApiAppDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiAppGetResponse&gt; ApiAppGet(ApiAppGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an object with information about an API App.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiApp.ApiAppGet(new ApiAppGetRequest
    {
        ClientId = "0dd3b823a682527788c4e40cb7b6f7e9",
    });
    // TODO: Handle 'response' of type ApiAppGetResponse
}
catch (ApiException<ApiAppGetError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ApiAppGetRequest](src/DropboxSignApi/Requests/ApiApp/ApiAppGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiAppGetResponse](src/DropboxSignApi/Models/ApiAppGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[ApiAppGetError](src/DropboxSignApi/Errors/ApiAppGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiAppListResponse&gt; ApiAppList(ApiAppListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of API Apps that are accessible by you. If you are on a team with an Admin or Developer role, this list will include apps owned by teammates.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiApp.ApiAppList(new ApiAppListRequest());
    // TODO: Handle 'response' of type ApiAppListResponse
}
catch (ApiException<ApiAppListError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ApiAppListRequest](src/DropboxSignApi/Requests/ApiApp/ApiAppListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiAppListResponse](src/DropboxSignApi/Models/ApiAppListResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[ApiAppListError](src/DropboxSignApi/Errors/ApiAppListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiAppGetResponse&gt; ApiAppUpdate(ApiAppUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an existing API App. Can only be invoked for apps you own. Only the fields you provide will be updated. If you wish to clear an existing optional field, provide an empty string.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiApp.ApiAppUpdate(new ApiAppUpdateOperationRequest
    {
        ClientId = "0dd3b823a682527788c4e40cb7b6f7e9",
    });
    // TODO: Handle 'response' of type ApiAppGetResponse
}
catch (ApiException<ApiAppUpdateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ApiAppUpdateOperationRequest](src/DropboxSignApi/Requests/ApiApp/ApiAppUpdateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiAppGetResponse](src/DropboxSignApi/Models/ApiAppGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[ApiAppUpdateError](src/DropboxSignApi/Errors/ApiAppUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## BulkSendJob

> Source: [BulkSendJob](src/DropboxSignApi/Api/BulkSendJob.cs)

<details>
<summary><code>Task&lt;BulkSendJobGetResponse&gt; BulkSendJobGet(BulkSendJobGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the status of the BulkSendJob and its SignatureRequests specified by the `bulk_send_job_id` parameter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BulkSendJob.BulkSendJobGet(new BulkSendJobGetRequest
    {
        BulkSendJobId = "6e683bc0369ba3d5b6f43c2c22a8031dbf6bd174",
    });
    // TODO: Handle 'response' of type BulkSendJobGetResponse
}
catch (ApiException<BulkSendJobGetError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkSendJobGetRequest](src/DropboxSignApi/Requests/BulkSendJob/BulkSendJobGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkSendJobGetResponse](src/DropboxSignApi/Models/BulkSendJobGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[BulkSendJobGetError](src/DropboxSignApi/Errors/BulkSendJobGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BulkSendJobListResponse&gt; BulkSendJobList(BulkSendJobListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of BulkSendJob that you can access.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BulkSendJob.BulkSendJobList(new BulkSendJobListRequest());
    // TODO: Handle 'response' of type BulkSendJobListResponse
}
catch (ApiException<BulkSendJobListError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkSendJobListRequest](src/DropboxSignApi/Requests/BulkSendJob/BulkSendJobListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkSendJobListResponse](src/DropboxSignApi/Models/BulkSendJobListResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[BulkSendJobListError](src/DropboxSignApi/Errors/BulkSendJobListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Document

> Source: [Document](src/DropboxSignApi/Api/Document.cs)

<details>
<summary><code>Task&lt;DocumentFieldDetectionResponse&gt; DocumentDetectFields(DocumentDetectFieldsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Detects form fields in a PDF document using either PDF form annotations or Dropbox Sign text tags.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Document.DocumentDetectFields(new DocumentDetectFieldsRequest
    {
        DetectionMode = "some example string",
        PageRange = "0-2,5,7-9",
    });
    // TODO: Handle 'response' of type DocumentFieldDetectionResponse
}
catch (ApiException<DocumentDetectFieldsError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DocumentDetectFieldsRequest](src/DropboxSignApi/Requests/Document/DocumentDetectFieldsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DocumentFieldDetectionResponse](src/DropboxSignApi/Models/DocumentFieldDetectionResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[DocumentDetectFieldsError](src/DropboxSignApi/Errors/DocumentDetectFieldsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Embedded

> Source: [Embedded](src/DropboxSignApi/Api/Embedded.cs)

<details>
<summary><code>Task&lt;EmbeddedEditUrlResponse&gt; EmbeddedEditUrl(EmbeddedEditUrlOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves an embedded object containing a template url that can be opened in an iFrame. Note that only templates created via the embedded template process are available to be edited with this endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Embedded.EmbeddedEditUrl(new EmbeddedEditUrlOperationRequest
    {
        TemplateId = "f57db65d3f933b5316d398057a36176831451a35",
        Body = new EmbeddedEditUrlRequest(),
    });
    // TODO: Handle 'response' of type EmbeddedEditUrlResponse
}
catch (ApiException<EmbeddedEditUrlError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EmbeddedEditUrlOperationRequest](src/DropboxSignApi/Requests/Embedded/EmbeddedEditUrlOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EmbeddedEditUrlResponse](src/DropboxSignApi/Models/EmbeddedEditUrlResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[EmbeddedEditUrlError](src/DropboxSignApi/Errors/EmbeddedEditUrlError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EmbeddedSignUrlResponse&gt; EmbeddedSignUrl(EmbeddedSignUrlRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves an embedded object containing a signature url that can be opened in an iFrame. Note that templates created via the embedded template process will only be accessible through the API.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Embedded.EmbeddedSignUrl(new EmbeddedSignUrlRequest
    {
        SignatureId = "50e3542f738adfa7ddd4cbd4c00d2a8ab6e4194b",
    });
    // TODO: Handle 'response' of type EmbeddedSignUrlResponse
}
catch (ApiException<EmbeddedSignUrlError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EmbeddedSignUrlRequest](src/DropboxSignApi/Requests/Embedded/EmbeddedSignUrlRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EmbeddedSignUrlResponse](src/DropboxSignApi/Models/EmbeddedSignUrlResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[EmbeddedSignUrlError](src/DropboxSignApi/Errors/EmbeddedSignUrlError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Fax

> Source: [Fax](src/DropboxSignApi/Api/Fax.cs)

<details>
<summary><code>Task FaxDelete(FaxDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the specified Fax from the system

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Fax.FaxDelete(new FaxDeleteRequest { FaxId = "fa5c8a0b0f492d768749333ad6fcc214c111e967" });
}
catch (ApiException<FaxDeleteError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FaxDeleteRequest](src/DropboxSignApi/Requests/Fax/FaxDeleteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[FaxDeleteError](src/DropboxSignApi/Errors/FaxDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task FaxFiles(FaxFilesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Downloads files associated with a Fax

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Fax.FaxFiles(new FaxFilesRequest { FaxId = "fa5c8a0b0f492d768749333ad6fcc214c111e967" });
}
catch (ApiException<FaxFilesError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FaxFilesRequest](src/DropboxSignApi/Requests/Fax/FaxFilesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[FaxFilesError](src/DropboxSignApi/Errors/FaxFilesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FaxGetResponse&gt; FaxGet(FaxGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns information about a Fax

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Fax.FaxGet(new FaxGetRequest { FaxId = "fa5c8a0b0f492d768749333ad6fcc214c111e967" });
    // TODO: Handle 'response' of type FaxGetResponse
}
catch (ApiException<FaxGetError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FaxGetRequest](src/DropboxSignApi/Requests/Fax/FaxGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FaxGetResponse](src/DropboxSignApi/Models/FaxGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[FaxGetError](src/DropboxSignApi/Errors/FaxGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FaxListResponse&gt; FaxList(FaxListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns properties of multiple Faxes

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Fax.FaxList(new FaxListRequest { Page = 1, PageSize = 20 });
    // TODO: Handle 'response' of type FaxListResponse
}
catch (ApiException<FaxListError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FaxListRequest](src/DropboxSignApi/Requests/Fax/FaxListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FaxListResponse](src/DropboxSignApi/Models/FaxListResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[FaxListError](src/DropboxSignApi/Errors/FaxListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FaxGetResponse&gt; FaxSend(FaxSendOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates and sends a new Fax with the submitted file(s)

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Fax.FaxSend(new FaxSendOperationRequest
    {
        Recipient = "recipient@example.com",
        Sender = "sender@example.com",
        CoverPageTo = "Recipient Name",
        CoverPageFrom = "Sender Name",
        CoverPageMessage = "Please find the attached documents.",
        Title = "Fax Title",
    });
    // TODO: Handle 'response' of type FaxGetResponse
}
catch (ApiException<FaxSendError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FaxSendOperationRequest](src/DropboxSignApi/Requests/Fax/FaxSendOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FaxGetResponse](src/DropboxSignApi/Models/FaxGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[FaxSendError](src/DropboxSignApi/Errors/FaxSendError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## FaxLine

> Source: [FaxLine](src/DropboxSignApi/Api/FaxLine.cs)

<details>
<summary><code>Task&lt;FaxLineResponse&gt; FaxLineAddUser(FaxLineAddUserOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Grants a user access to the specified Fax Line.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FaxLine.FaxLineAddUser(new FaxLineAddUserOperationRequest
    {
        Body = new FaxLineAddUserRequest { Number = "some example string" },
    });
    // TODO: Handle 'response' of type FaxLineResponse
}
catch (ApiException<FaxLineAddUserError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FaxLineAddUserOperationRequest](src/DropboxSignApi/Requests/FaxLine/FaxLineAddUserOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FaxLineResponse](src/DropboxSignApi/Models/FaxLineResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[FaxLineAddUserError](src/DropboxSignApi/Errors/FaxLineAddUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FaxLineAreaCodeGetResponse&gt; FaxLineAreaCodeGet(FaxLineAreaCodeGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of available area codes for a given state/province and city

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FaxLine.FaxLineAreaCodeGet(new FaxLineAreaCodeGetRequest
    {
        Country = FaxLineAreaCodeGetCountryEnum.Us,
    });
    // TODO: Handle 'response' of type FaxLineAreaCodeGetResponse
}
catch (ApiException<FaxLineAreaCodeGetError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FaxLineAreaCodeGetRequest](src/DropboxSignApi/Requests/FaxLine/FaxLineAreaCodeGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FaxLineAreaCodeGetResponse](src/DropboxSignApi/Models/FaxLineAreaCodeGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[FaxLineAreaCodeGetError](src/DropboxSignApi/Errors/FaxLineAreaCodeGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FaxLineResponse&gt; FaxLineCreate(FaxLineCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Purchases a new Fax Line

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FaxLine.FaxLineCreate(new FaxLineCreateOperationRequest
    {
        Body = new FaxLineCreateRequest { AreaCode = 1, Country = Country.Ca },
    });
    // TODO: Handle 'response' of type FaxLineResponse
}
catch (ApiException<FaxLineCreateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FaxLineCreateOperationRequest](src/DropboxSignApi/Requests/FaxLine/FaxLineCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FaxLineResponse](src/DropboxSignApi/Models/FaxLineResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[FaxLineCreateError](src/DropboxSignApi/Errors/FaxLineCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; FaxLineDelete(FaxLineDeleteOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the specified Fax Line from the subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FaxLine.FaxLineDelete(new FaxLineDeleteOperationRequest
    {
        Body = new FaxLineDeleteRequest { Number = "some example string" },
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<FaxLineDeleteError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FaxLineDeleteOperationRequest](src/DropboxSignApi/Requests/FaxLine/FaxLineDeleteOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[FaxLineDeleteError](src/DropboxSignApi/Errors/FaxLineDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FaxLineResponse&gt; FaxLineGet(FaxLineGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the properties and settings of a Fax Line.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FaxLine.FaxLineGet(new FaxLineGetRequest { Number = "123-123-1234" });
    // TODO: Handle 'response' of type FaxLineResponse
}
catch (ApiException<FaxLineGetError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FaxLineGetRequest](src/DropboxSignApi/Requests/FaxLine/FaxLineGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FaxLineResponse](src/DropboxSignApi/Models/FaxLineResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[FaxLineGetError](src/DropboxSignApi/Errors/FaxLineGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FaxLineListResponse&gt; FaxLineList(FaxLineListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the properties and settings of multiple Fax Lines.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FaxLine.FaxLineList(new FaxLineListRequest
    {
        AccountId = "ab55cd14a97219e36b5ff5fe23f2f9329b0c1e97",
        Page = 1,
        PageSize = 20,
    });
    // TODO: Handle 'response' of type FaxLineListResponse
}
catch (ApiException<FaxLineListError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FaxLineListRequest](src/DropboxSignApi/Requests/FaxLine/FaxLineListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FaxLineListResponse](src/DropboxSignApi/Models/FaxLineListResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[FaxLineListError](src/DropboxSignApi/Errors/FaxLineListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FaxLineResponse&gt; FaxLineRemoveUser(FaxLineRemoveUserOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes a user's access to the specified Fax Line

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FaxLine.FaxLineRemoveUser(new FaxLineRemoveUserOperationRequest
    {
        Body = new FaxLineRemoveUserRequest { Number = "some example string" },
    });
    // TODO: Handle 'response' of type FaxLineResponse
}
catch (ApiException<FaxLineRemoveUserError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FaxLineRemoveUserOperationRequest](src/DropboxSignApi/Requests/FaxLine/FaxLineRemoveUserOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FaxLineResponse](src/DropboxSignApi/Models/FaxLineResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[FaxLineRemoveUserError](src/DropboxSignApi/Errors/FaxLineRemoveUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## OAuth

> Source: [OAuth](src/DropboxSignApi/Api/OAuth.cs)

<details>
<summary><code>Task&lt;OAuthTokenResponse&gt; OauthTokenGenerate(OauthTokenGenerateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Once you have retrieved the code from the user callback, you will need to exchange it for an access token via a backend call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OAuth.OauthTokenGenerate(new OauthTokenGenerateOperationRequest
    {
        Body = new OAuthTokenGenerateRequest
        {
            ClientId = "some example string",
            ClientSecret = "some example string",
            Code = "some example string",
            GrantType = "some example string",
            State = "some example string",
        },
    });
    // TODO: Handle 'response' of type OAuthTokenResponse
}
catch (ApiException<OauthTokenGenerateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[OauthTokenGenerateOperationRequest](src/DropboxSignApi/Requests/OAuth/OauthTokenGenerateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OAuthTokenResponse](src/DropboxSignApi/Models/OAuthTokenResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[OauthTokenGenerateError](src/DropboxSignApi/Errors/OauthTokenGenerateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OAuthTokenResponse&gt; OauthTokenRefresh(OauthTokenRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Access tokens are only valid for a given period of time (typically one hour) for security reasons. Whenever acquiring an new access token its TTL is also given (see `expires_in`), along with a refresh token that can be used to acquire a new access token after the current one has expired.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OAuth.OauthTokenRefresh(new OauthTokenRefreshOperationRequest
    {
        Body = new OAuthTokenRefreshRequest { GrantType = "some example string", RefreshToken = "some example string" },
    });
    // TODO: Handle 'response' of type OAuthTokenResponse
}
catch (ApiException<OauthTokenRefreshError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[OauthTokenRefreshOperationRequest](src/DropboxSignApi/Requests/OAuth/OauthTokenRefreshOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OAuthTokenResponse](src/DropboxSignApi/Models/OAuthTokenResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[OauthTokenRefreshError](src/DropboxSignApi/Errors/OauthTokenRefreshError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Report

> Source: [Report](src/DropboxSignApi/Api/Report.cs)

<details>
<summary><code>Task&lt;ReportCreateResponse&gt; ReportCreate(ReportCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Request the creation of one or more report(s).

When the report(s) have been generated, you will receive an email (one per requested report type) containing a link to download the report as a CSV file. The requested date range may be up to 12 months in duration, and `start_date` must not be more than 10 years in the past.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Report.ReportCreate(new ReportCreateOperationRequest
    {
        Body = new ReportCreateRequest
        {
            EndDate = "some example string",
            ReportType = [ReportType.UserActivity],
            StartDate = "some example string",
        },
    });
    // TODO: Handle 'response' of type ReportCreateResponse
}
catch (ApiException<ReportCreateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ReportCreateOperationRequest](src/DropboxSignApi/Requests/Report/ReportCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReportCreateResponse](src/DropboxSignApi/Models/ReportCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[ReportCreateError](src/DropboxSignApi/Errors/ReportCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SignatureRequest

> Source: [SignatureRequest](src/DropboxSignApi/Api/SignatureRequest.cs)

<details>
<summary><code>Task&lt;BulkSendJobSendResponse&gt; SignatureRequestBulkCreateEmbeddedWithTemplate(SignatureRequestBulkCreateEmbeddedWithTemplateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates BulkSendJob which sends up to 250 SignatureRequests in bulk based off of the provided Template(s) specified with the `template_ids` parameter to be signed in an embedded iFrame. These embedded signature requests can only be signed in embedded iFrames whereas normal signature requests can only be signed on Dropbox Sign.

**NOTE:** Only available for Standard plan and higher.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignatureRequest.SignatureRequestBulkCreateEmbeddedWithTemplate(
        new SignatureRequestBulkCreateEmbeddedWithTemplateOperationRequest
        {
            TemplateIds = ["some example string"],
            ClientId = "some example string",
        });
    // TODO: Handle 'response' of type BulkSendJobSendResponse
}
catch (ApiException<SignatureRequestBulkCreateEmbeddedWithTemplateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignatureRequestBulkCreateEmbeddedWithTemplateOperationRequest](src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestBulkCreateEmbeddedWithTemplateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkSendJobSendResponse](src/DropboxSignApi/Models/BulkSendJobSendResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[SignatureRequestBulkCreateEmbeddedWithTemplateError](src/DropboxSignApi/Errors/SignatureRequestBulkCreateEmbeddedWithTemplateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BulkSendJobSendResponse&gt; SignatureRequestBulkSendWithTemplate(SignatureRequestBulkSendWithTemplateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates BulkSendJob which sends up to 250 SignatureRequests in bulk based off of the provided Template(s) specified with the `template_ids` parameter.

**NOTE:** Only available for Standard plan and higher.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignatureRequest.SignatureRequestBulkSendWithTemplate(
        new SignatureRequestBulkSendWithTemplateOperationRequest { TemplateIds = ["some example string"] });
    // TODO: Handle 'response' of type BulkSendJobSendResponse
}
catch (ApiException<SignatureRequestBulkSendWithTemplateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignatureRequestBulkSendWithTemplateOperationRequest](src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestBulkSendWithTemplateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkSendJobSendResponse](src/DropboxSignApi/Models/BulkSendJobSendResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[SignatureRequestBulkSendWithTemplateError](src/DropboxSignApi/Errors/SignatureRequestBulkSendWithTemplateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; SignatureRequestCancel(SignatureRequestCancelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels an incomplete signature request. This action is **not reversible**.

The request will be canceled and signers will no longer be able to sign. If they try to access the signature request they will receive a HTTP 410 status code indicating that the resource has been deleted. Cancelation is asynchronous and a successful call to this endpoint will return an empty 200 OK response if the signature request is eligible to be canceled and has been successfully queued.

This 200 OK response does not indicate a successful cancelation of the signature request itself. The cancelation is confirmed via the `signature_request_canceled` event. It is recommended that a [callback handler](/api/reference/tag/Callbacks-and-Events) be implemented to listen for the `signature_request_canceled` event. This callback will be sent only when the cancelation has completed successfully. If a callback handler has been configured and the event has not been received within 60 minutes of making the call, check the status of the request in the [API Dashboard](https://app.hellosign.com/apidashboard) and retry the cancelation if necessary.

To be eligible for cancelation, a signature request must have been sent successfully, must not yet have been signed by all signers, and you must either be the sender or own the API app under which it was sent. A partially signed signature request can be canceled.

**NOTE:** To remove your access to a completed signature request, use the endpoint: `POST /signature_request/remove/[:signature_request_id]`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignatureRequest.SignatureRequestCancel(new SignatureRequestCancelRequest
    {
        SignatureRequestId = "fa5c8a0b0f492d768749333ad6fcc214c111e967",
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<SignatureRequestCancelError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignatureRequestCancelRequest](src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestCancelRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[SignatureRequestCancelError](src/DropboxSignApi/Errors/SignatureRequestCancelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignatureRequestGetResponse&gt; SignatureRequestCreateEmbedded(SignatureRequestCreateEmbeddedOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new SignatureRequest with the submitted documents to be signed in an embedded iFrame. If form_fields_per_document is not specified, a signature page will be affixed where all signers will be required to add their signature, signifying their agreement to all contained documents. Note that embedded signature requests can only be signed in embedded iFrames whereas normal signature requests can only be signed on Dropbox Sign.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignatureRequest.SignatureRequestCreateEmbedded(
        new SignatureRequestCreateEmbeddedOperationRequest { ClientId = "some example string" });
    // TODO: Handle 'response' of type SignatureRequestGetResponse
}
catch (ApiException<SignatureRequestCreateEmbeddedError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignatureRequestCreateEmbeddedOperationRequest](src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestCreateEmbeddedOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignatureRequestGetResponse](src/DropboxSignApi/Models/SignatureRequestGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[SignatureRequestCreateEmbeddedError](src/DropboxSignApi/Errors/SignatureRequestCreateEmbeddedError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignatureRequestGetResponse&gt; SignatureRequestCreateEmbeddedWithTemplate(SignatureRequestCreateEmbeddedWithTemplateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new SignatureRequest based on the given Template(s) to be signed in an embedded iFrame. Note that embedded signature requests can only be signed in embedded iFrames whereas normal signature requests can only be signed on Dropbox Sign.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignatureRequest.SignatureRequestCreateEmbeddedWithTemplate(
        new SignatureRequestCreateEmbeddedWithTemplateOperationRequest
        {
            TemplateIds = ["some example string"],
            ClientId = "some example string",
            Signers = [
                new SubSignatureRequestTemplateSigner
                {
                    Role = "some example string",
                    Name = "some example string",
                    EmailAddress = "user@example.com",
                },
            ],
        });
    // TODO: Handle 'response' of type SignatureRequestGetResponse
}
catch (ApiException<SignatureRequestCreateEmbeddedWithTemplateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignatureRequestCreateEmbeddedWithTemplateOperationRequest](src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestCreateEmbeddedWithTemplateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignatureRequestGetResponse](src/DropboxSignApi/Models/SignatureRequestGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[SignatureRequestCreateEmbeddedWithTemplateError](src/DropboxSignApi/Errors/SignatureRequestCreateEmbeddedWithTemplateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignatureRequestGetResponse&gt; SignatureRequestEdit(SignatureRequestEditOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Edits and sends a SignatureRequest with the submitted documents. If `form_fields_per_document` is not specified, a signature page will be affixed where all signers will be required to add their signature, signifying their agreement to all contained documents.

**NOTE:** Edit and resend *will* deduct your signature request quota.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignatureRequest.SignatureRequestEdit(new SignatureRequestEditOperationRequest
    {
        SignatureRequestId = "fa5c8a0b0f492d768749333ad6fcc214c111e967",
    });
    // TODO: Handle 'response' of type SignatureRequestGetResponse
}
catch (ApiException<SignatureRequestEditError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignatureRequestEditOperationRequest](src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestEditOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignatureRequestGetResponse](src/DropboxSignApi/Models/SignatureRequestGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[SignatureRequestEditError](src/DropboxSignApi/Errors/SignatureRequestEditError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignatureRequestGetResponse&gt; SignatureRequestEditEmbedded(SignatureRequestEditEmbeddedOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Edits a SignatureRequest with the submitted documents to be signed in an embedded iFrame. If form_fields_per_document is not specified, a signature page will be affixed where all signers will be required to add their signature, signifying their agreement to all contained documents. Note that embedded signature requests can only be signed in embedded iFrames whereas normal signature requests can only be signed on Dropbox Sign.

**NOTE:** Edit and resend *will* deduct your signature request quota.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignatureRequest.SignatureRequestEditEmbedded(
        new SignatureRequestEditEmbeddedOperationRequest
        {
            SignatureRequestId = "fa5c8a0b0f492d768749333ad6fcc214c111e967",
            ClientId = "some example string",
        });
    // TODO: Handle 'response' of type SignatureRequestGetResponse
}
catch (ApiException<SignatureRequestEditEmbeddedError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignatureRequestEditEmbeddedOperationRequest](src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestEditEmbeddedOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignatureRequestGetResponse](src/DropboxSignApi/Models/SignatureRequestGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[SignatureRequestEditEmbeddedError](src/DropboxSignApi/Errors/SignatureRequestEditEmbeddedError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignatureRequestGetResponse&gt; SignatureRequestEditEmbeddedWithTemplate(SignatureRequestEditEmbeddedWithTemplateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Edits a SignatureRequest based on the given Template(s) to be signed in an embedded iFrame. Note that embedded signature requests can only be signed in embedded iFrames whereas normal signature requests can only be signed on Dropbox Sign.

**NOTE:** Edit and resend *will* deduct your signature request quota.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignatureRequest.SignatureRequestEditEmbeddedWithTemplate(
        new SignatureRequestEditEmbeddedWithTemplateOperationRequest
        {
            SignatureRequestId = "fa5c8a0b0f492d768749333ad6fcc214c111e967",
            TemplateIds = ["some example string"],
            ClientId = "some example string",
            Signers = [
                new SubSignatureRequestTemplateSigner
                {
                    Role = "some example string",
                    Name = "some example string",
                    EmailAddress = "user@example.com",
                },
            ],
        });
    // TODO: Handle 'response' of type SignatureRequestGetResponse
}
catch (ApiException<SignatureRequestEditEmbeddedWithTemplateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignatureRequestEditEmbeddedWithTemplateOperationRequest](src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestEditEmbeddedWithTemplateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignatureRequestGetResponse](src/DropboxSignApi/Models/SignatureRequestGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[SignatureRequestEditEmbeddedWithTemplateError](src/DropboxSignApi/Errors/SignatureRequestEditEmbeddedWithTemplateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignatureRequestGetResponse&gt; SignatureRequestEditWithTemplate(SignatureRequestEditWithTemplateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Edits and sends a SignatureRequest based off of the Template(s) specified with the template_ids parameter.

**NOTE:** Edit and resend *will* deduct your signature request quota.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignatureRequest.SignatureRequestEditWithTemplate(
        new SignatureRequestEditWithTemplateOperationRequest
        {
            SignatureRequestId = "fa5c8a0b0f492d768749333ad6fcc214c111e967",
            TemplateIds = ["some example string"],
            Signers = [
                new SubSignatureRequestTemplateSigner
                {
                    Role = "some example string",
                    Name = "some example string",
                    EmailAddress = "user@example.com",
                },
            ],
        });
    // TODO: Handle 'response' of type SignatureRequestGetResponse
}
catch (ApiException<SignatureRequestEditWithTemplateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignatureRequestEditWithTemplateOperationRequest](src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestEditWithTemplateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignatureRequestGetResponse](src/DropboxSignApi/Models/SignatureRequestGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[SignatureRequestEditWithTemplateError](src/DropboxSignApi/Errors/SignatureRequestEditWithTemplateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SignatureRequestFiles(SignatureRequestFilesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Obtain a copy of the current documents specified by the `signature_request_id` parameter. Returns a PDF or ZIP file.

If the files are currently being prepared, a status code of `409` will be returned instead.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SignatureRequest.SignatureRequestFiles(new SignatureRequestFilesRequest
    {
        SignatureRequestId = "fa5c8a0b0f492d768749333ad6fcc214c111e967",
    });
}
catch (ApiException<SignatureRequestFilesError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignatureRequestFilesRequest](src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestFilesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[SignatureRequestFilesError](src/DropboxSignApi/Errors/SignatureRequestFilesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FileResponseDataUri&gt; SignatureRequestFilesAsDataUri(SignatureRequestFilesAsDataUriRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Obtain a copy of the current documents specified by the `signature_request_id` parameter. Returns a JSON object with a `data_uri` representing the base64 encoded file (PDFs only).

If the files are currently being prepared, a status code of `409` will be returned instead.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignatureRequest.SignatureRequestFilesAsDataUri(
        new SignatureRequestFilesAsDataUriRequest { SignatureRequestId = "fa5c8a0b0f492d768749333ad6fcc214c111e967" });
    // TODO: Handle 'response' of type FileResponseDataUri
}
catch (ApiException<SignatureRequestFilesAsDataUriError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignatureRequestFilesAsDataUriRequest](src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestFilesAsDataUriRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FileResponseDataUri](src/DropboxSignApi/Models/FileResponseDataUri.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[SignatureRequestFilesAsDataUriError](src/DropboxSignApi/Errors/SignatureRequestFilesAsDataUriError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FileResponse&gt; SignatureRequestFilesAsFileUrl(SignatureRequestFilesAsFileUrlRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Obtain a copy of the current documents specified by the `signature_request_id` parameter. Returns a JSON object with a url to the file (PDFs only).

If the files are currently being prepared, a status code of `409` will be returned instead.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignatureRequest.SignatureRequestFilesAsFileUrl(
        new SignatureRequestFilesAsFileUrlRequest { SignatureRequestId = "fa5c8a0b0f492d768749333ad6fcc214c111e967" });
    // TODO: Handle 'response' of type FileResponse
}
catch (ApiException<SignatureRequestFilesAsFileUrlError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignatureRequestFilesAsFileUrlRequest](src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestFilesAsFileUrlRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FileResponse](src/DropboxSignApi/Models/FileResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[SignatureRequestFilesAsFileUrlError](src/DropboxSignApi/Errors/SignatureRequestFilesAsFileUrlError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignatureRequestGetResponse&gt; SignatureRequestGet(SignatureRequestGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the status of the SignatureRequest specified by the `signature_request_id` parameter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignatureRequest.SignatureRequestGet(new SignatureRequestGetRequest
    {
        SignatureRequestId = "fa5c8a0b0f492d768749333ad6fcc214c111e967",
    });
    // TODO: Handle 'response' of type SignatureRequestGetResponse
}
catch (ApiException<SignatureRequestGetError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignatureRequestGetRequest](src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignatureRequestGetResponse](src/DropboxSignApi/Models/SignatureRequestGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[SignatureRequestGetError](src/DropboxSignApi/Errors/SignatureRequestGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignatureRequestListResponse&gt; SignatureRequestList(SignatureRequestListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of SignatureRequests that you can access. This includes SignatureRequests you have sent as well as received, but not ones that you have been CCed on.

Take a look at our [search guide](/api/reference/search/) to learn more about querying signature requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignatureRequest.SignatureRequestList(new SignatureRequestListRequest { Page = 1 });
    // TODO: Handle 'response' of type SignatureRequestListResponse
}
catch (ApiException<SignatureRequestListError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignatureRequestListRequest](src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignatureRequestListResponse](src/DropboxSignApi/Models/SignatureRequestListResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[SignatureRequestListError](src/DropboxSignApi/Errors/SignatureRequestListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignatureRequestGetResponse&gt; SignatureRequestReleaseHold(SignatureRequestReleaseHoldRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Releases a held SignatureRequest that was claimed and prepared from an [UnclaimedDraft](/api/reference/tag/Unclaimed-Draft). The owner of the Draft must indicate at Draft creation that the SignatureRequest created from the Draft should be held. Releasing the SignatureRequest will send requests to all signers.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignatureRequest.SignatureRequestReleaseHold(new SignatureRequestReleaseHoldRequest
    {
        SignatureRequestId = "fa5c8a0b0f492d768749333ad6fcc214c111e967",
    });
    // TODO: Handle 'response' of type SignatureRequestGetResponse
}
catch (ApiException<SignatureRequestReleaseHoldError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignatureRequestReleaseHoldRequest](src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestReleaseHoldRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignatureRequestGetResponse](src/DropboxSignApi/Models/SignatureRequestGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[SignatureRequestReleaseHoldError](src/DropboxSignApi/Errors/SignatureRequestReleaseHoldError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignatureRequestGetResponse&gt; SignatureRequestRemind(SignatureRequestRemindOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sends an email to the signer reminding them to sign the signature request. You cannot send a reminder within 1 hour of the last reminder that was sent. This includes manual AND automatic reminders.

**NOTE:** This action can **not** be used with embedded signature requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignatureRequest.SignatureRequestRemind(new SignatureRequestRemindOperationRequest
    {
        SignatureRequestId = "fa5c8a0b0f492d768749333ad6fcc214c111e967",
        Body = new SignatureRequestRemindRequest { EmailAddress = "user@example.com" },
    });
    // TODO: Handle 'response' of type SignatureRequestGetResponse
}
catch (ApiException<SignatureRequestRemindError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignatureRequestRemindOperationRequest](src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestRemindOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignatureRequestGetResponse](src/DropboxSignApi/Models/SignatureRequestGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[SignatureRequestRemindError](src/DropboxSignApi/Errors/SignatureRequestRemindError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; SignatureRequestRemove(SignatureRequestRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes your access to a completed signature request. This action is **not reversible**.

The signature request must be fully executed by all parties (signed or declined to sign). Other parties will continue to maintain access to the completed signature request document(s).

Unlike /signature_request/cancel, this endpoint is synchronous and your access will be immediately removed. Upon successful removal, this endpoint will return a 200 OK response.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignatureRequest.SignatureRequestRemove(new SignatureRequestRemoveRequest
    {
        SignatureRequestId = "fa5c8a0b0f492d768749333ad6fcc214c111e967",
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<SignatureRequestRemoveError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignatureRequestRemoveRequest](src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestRemoveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[SignatureRequestRemoveError](src/DropboxSignApi/Errors/SignatureRequestRemoveError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignatureRequestGetResponse&gt; SignatureRequestSend(SignatureRequestSendOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates and sends a new SignatureRequest with the submitted documents. If `form_fields_per_document` is not specified, a signature page will be affixed where all signers will be required to add their signature, signifying their agreement to all contained documents.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignatureRequest.SignatureRequestSend(new SignatureRequestSendOperationRequest());
    // TODO: Handle 'response' of type SignatureRequestGetResponse
}
catch (ApiException<SignatureRequestSendError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignatureRequestSendOperationRequest](src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestSendOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignatureRequestGetResponse](src/DropboxSignApi/Models/SignatureRequestGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[SignatureRequestSendError](src/DropboxSignApi/Errors/SignatureRequestSendError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignatureRequestGetResponse&gt; SignatureRequestSendWithTemplate(SignatureRequestSendWithTemplateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates and sends a new SignatureRequest based off of the Template(s) specified with the `template_ids` parameter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignatureRequest.SignatureRequestSendWithTemplate(
        new SignatureRequestSendWithTemplateOperationRequest
        {
            TemplateIds = ["some example string"],
            Signers = [
                new SubSignatureRequestTemplateSigner
                {
                    Role = "some example string",
                    Name = "some example string",
                    EmailAddress = "user@example.com",
                },
            ],
        });
    // TODO: Handle 'response' of type SignatureRequestGetResponse
}
catch (ApiException<SignatureRequestSendWithTemplateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignatureRequestSendWithTemplateOperationRequest](src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestSendWithTemplateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignatureRequestGetResponse](src/DropboxSignApi/Models/SignatureRequestGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[SignatureRequestSendWithTemplateError](src/DropboxSignApi/Errors/SignatureRequestSendWithTemplateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignatureRequestGetResponse&gt; SignatureRequestUpdate(SignatureRequestUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the email address and/or the name for a given signer on a signature request. You can listen for the `signature_request_email_bounce` event on your app or account to detect bounced emails, and respond with this method.

Updating the email address of a signer will generate a new `signature_id` value.

**NOTE:** This action cannot be performed on a signature request with an appended signature page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignatureRequest.SignatureRequestUpdate(new SignatureRequestUpdateOperationRequest
    {
        SignatureRequestId = "fa5c8a0b0f492d768749333ad6fcc214c111e967",
        Body = new SignatureRequestUpdateRequest { SignatureId = "some example string" },
    });
    // TODO: Handle 'response' of type SignatureRequestGetResponse
}
catch (ApiException<SignatureRequestUpdateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignatureRequestUpdateOperationRequest](src/DropboxSignApi/Requests/SignatureRequest/SignatureRequestUpdateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignatureRequestGetResponse](src/DropboxSignApi/Models/SignatureRequestGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[SignatureRequestUpdateError](src/DropboxSignApi/Errors/SignatureRequestUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Team

> Source: [Team](src/DropboxSignApi/Api/Team.cs)

<details>
<summary><code>Task&lt;TeamGetResponse&gt; TeamAddMember(TeamAddMemberOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Invites a user (specified using the `email_address` parameter) to your Team. If the user does not currently have a Dropbox Sign Account, a new one will be created for them. If a user is already a part of another Team, a `team_invite_failed` error will be returned.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.TeamAddMember(new TeamAddMemberOperationRequest
    {
        TeamId = "4fea99bfcf2b26bfccf6cea3e127fb8bb74d8d9c",
        Body = new TeamAddMemberRequest(),
    });
    // TODO: Handle 'response' of type TeamGetResponse
}
catch (ApiException<TeamAddMemberError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TeamAddMemberOperationRequest](src/DropboxSignApi/Requests/Team/TeamAddMemberOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamGetResponse](src/DropboxSignApi/Models/TeamGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TeamAddMemberError](src/DropboxSignApi/Errors/TeamAddMemberError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamGetResponse&gt; TeamCreate(TeamCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new Team and makes you a member. You must not currently belong to a Team to invoke.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.TeamCreate(new TeamCreateOperationRequest { Body = new TeamCreateRequest() });
    // TODO: Handle 'response' of type TeamGetResponse
}
catch (ApiException<TeamCreateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TeamCreateOperationRequest](src/DropboxSignApi/Requests/Team/TeamCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamGetResponse](src/DropboxSignApi/Models/TeamGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TeamCreateError](src/DropboxSignApi/Errors/TeamCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task TeamDelete(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes your Team. Can only be invoked when you have a Team with only one member (yourself).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Team.TeamDelete();
}
catch (ApiException<TeamDeleteError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TeamDeleteError](src/DropboxSignApi/Errors/TeamDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamGetResponse&gt; TeamGet(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns information about your Team as well as a list of its members. If you do not belong to a Team, a 404 error with an error_name of "not_found" will be returned.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.TeamGet();
    // TODO: Handle 'response' of type TeamGetResponse
}
catch (ApiException<TeamGetError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamGetResponse](src/DropboxSignApi/Models/TeamGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TeamGetError](src/DropboxSignApi/Errors/TeamGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamGetInfoResponse&gt; TeamInfo(TeamInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides information about a team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.TeamInfo(new TeamInfoRequest
    {
        TeamId = "4fea99bfcf2b26bfccf6cea3e127fb8bb74d8d9c",
    });
    // TODO: Handle 'response' of type TeamGetInfoResponse
}
catch (ApiException<TeamInfoError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TeamInfoRequest](src/DropboxSignApi/Requests/Team/TeamInfoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamGetInfoResponse](src/DropboxSignApi/Models/TeamGetInfoResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TeamInfoError](src/DropboxSignApi/Errors/TeamInfoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamInvitesResponse&gt; TeamInvites(TeamInvitesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides a list of team invites (and their roles).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.TeamInvites(new TeamInvitesRequest());
    // TODO: Handle 'response' of type TeamInvitesResponse
}
catch (ApiException<TeamInvitesError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TeamInvitesRequest](src/DropboxSignApi/Requests/Team/TeamInvitesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamInvitesResponse](src/DropboxSignApi/Models/TeamInvitesResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TeamInvitesError](src/DropboxSignApi/Errors/TeamInvitesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamMembersResponse&gt; TeamMembers(TeamMembersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides a paginated list of members (and their roles) that belong to a given team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.TeamMembers(new TeamMembersRequest
    {
        TeamId = "4fea99bfcf2b26bfccf6cea3e127fb8bb74d8d9c",
    });
    // TODO: Handle 'response' of type TeamMembersResponse
}
catch (ApiException<TeamMembersError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TeamMembersRequest](src/DropboxSignApi/Requests/Team/TeamMembersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamMembersResponse](src/DropboxSignApi/Models/TeamMembersResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TeamMembersError](src/DropboxSignApi/Errors/TeamMembersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamGetResponse&gt; TeamRemoveMember(TeamRemoveMemberOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes the provided user Account from your Team. If the Account had an outstanding invitation to your Team, the invitation will be expired. If you choose to transfer documents from the removed Account to an Account provided in the `new_owner_email_address` parameter (available only for Enterprise plans), the response status code will be 201, which indicates that your request has been queued but not fully executed.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.TeamRemoveMember(new TeamRemoveMemberOperationRequest
    {
        Body = new TeamRemoveMemberRequest(),
    });
    // TODO: Handle 'response' of type TeamGetResponse
}
catch (ApiException<TeamRemoveMemberError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TeamRemoveMemberOperationRequest](src/DropboxSignApi/Requests/Team/TeamRemoveMemberOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamGetResponse](src/DropboxSignApi/Models/TeamGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TeamRemoveMemberError](src/DropboxSignApi/Errors/TeamRemoveMemberError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamSubTeamsResponse&gt; TeamSubTeams(TeamSubTeamsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides a paginated list of sub teams that belong to a given team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.TeamSubTeams(new TeamSubTeamsRequest
    {
        TeamId = "4fea99bfcf2b26bfccf6cea3e127fb8bb74d8d9c",
    });
    // TODO: Handle 'response' of type TeamSubTeamsResponse
}
catch (ApiException<TeamSubTeamsError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TeamSubTeamsRequest](src/DropboxSignApi/Requests/Team/TeamSubTeamsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamSubTeamsResponse](src/DropboxSignApi/Models/TeamSubTeamsResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TeamSubTeamsError](src/DropboxSignApi/Errors/TeamSubTeamsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TeamGetResponse&gt; TeamUpdate(TeamUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the name of your Team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.TeamUpdate(new TeamUpdateOperationRequest { Body = new TeamUpdateRequest() });
    // TODO: Handle 'response' of type TeamGetResponse
}
catch (ApiException<TeamUpdateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TeamUpdateOperationRequest](src/DropboxSignApi/Requests/Team/TeamUpdateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TeamGetResponse](src/DropboxSignApi/Models/TeamGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TeamUpdateError](src/DropboxSignApi/Errors/TeamUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Template

> Source: [Template](src/DropboxSignApi/Api/Template.cs)

<details>
<summary><code>Task&lt;TemplateGetResponse&gt; TemplateAddUser(TemplateAddUserOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gives the specified Account access to the specified Template. The specified Account must be a part of your Team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Template.TemplateAddUser(new TemplateAddUserOperationRequest
    {
        TemplateId = "f57db65d3f933b5316d398057a36176831451a35",
        Body = new TemplateAddUserRequest(),
    });
    // TODO: Handle 'response' of type TemplateGetResponse
}
catch (ApiException<TemplateAddUserError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TemplateAddUserOperationRequest](src/DropboxSignApi/Requests/Template/TemplateAddUserOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TemplateGetResponse](src/DropboxSignApi/Models/TemplateGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TemplateAddUserError](src/DropboxSignApi/Errors/TemplateAddUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TemplateCreateResponse&gt; TemplateCreate(TemplateCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a template that can be used in future signature requests.

If `client_id` is provided, the template will be created as an embedded template. Embedded templates can be used for embedded signature requests and can be edited later by generating a new `edit_url` with [/embedded/edit_url/{template_id}](/api/reference/operation/embeddedEditUrl/).

Template creation may complete asynchronously after the initial request is accepted. It is recommended that a callback be implemented to listen for the callback event. A `template_created` event indicates the template is ready to use, while a `template_error` event indicates there was a problem while creating the template. If a callback handler has been configured and the event has not been received within 60 minutes of making the call, check the status of the request in the API dashboard and retry the request if necessary.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Template.TemplateCreate(new TemplateCreateOperationRequest
    {
        FormFieldsPerDocument = [
            new SubFormFieldsPerDocumentBase
            {
                DocumentIndex = 1,
                ApiId = "some example string",
                Height = 1,
                Required = true,
                Signer = "some example string",
                Type = "checkbox",
                Width = 1,
                X = 1,
                Y = 1,
            },
        ],
        SignerRoles = [new SubTemplateRole()],
    });
    // TODO: Handle 'response' of type TemplateCreateResponse
}
catch (ApiException<TemplateCreateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TemplateCreateOperationRequest](src/DropboxSignApi/Requests/Template/TemplateCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TemplateCreateResponse](src/DropboxSignApi/Models/TemplateCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TemplateCreateError](src/DropboxSignApi/Errors/TemplateCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TemplateCreateEmbeddedDraftResponse&gt; TemplateCreateEmbeddedDraft(TemplateCreateEmbeddedDraftOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The first step in an embedded template workflow. Creates a draft template that can then be further set up in the template 'edit' stage.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Template.TemplateCreateEmbeddedDraft(new TemplateCreateEmbeddedDraftOperationRequest
    {
        ClientId = "some example string",
    });
    // TODO: Handle 'response' of type TemplateCreateEmbeddedDraftResponse
}
catch (ApiException<TemplateCreateEmbeddedDraftError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TemplateCreateEmbeddedDraftOperationRequest](src/DropboxSignApi/Requests/Template/TemplateCreateEmbeddedDraftOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TemplateCreateEmbeddedDraftResponse](src/DropboxSignApi/Models/TemplateCreateEmbeddedDraftResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TemplateCreateEmbeddedDraftError](src/DropboxSignApi/Errors/TemplateCreateEmbeddedDraftError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; TemplateDelete(TemplateDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Completely deletes the template specified from the account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Template.TemplateDelete(new TemplateDeleteRequest
    {
        TemplateId = "f57db65d3f933b5316d398057a36176831451a35",
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<TemplateDeleteError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TemplateDeleteRequest](src/DropboxSignApi/Requests/Template/TemplateDeleteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TemplateDeleteError](src/DropboxSignApi/Errors/TemplateDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task TemplateFiles(TemplateFilesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Obtain a copy of the current documents specified by the `template_id` parameter. Returns a PDF or ZIP file.

If the files are currently being prepared, a status code of `409` will be returned instead. In this case please wait for the `template_created` callback event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Template.TemplateFiles(new TemplateFilesRequest
    {
        TemplateId = "f57db65d3f933b5316d398057a36176831451a35",
    });
}
catch (ApiException<TemplateFilesError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TemplateFilesRequest](src/DropboxSignApi/Requests/Template/TemplateFilesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TemplateFilesError](src/DropboxSignApi/Errors/TemplateFilesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FileResponseDataUri&gt; TemplateFilesAsDataUri(TemplateFilesAsDataUriRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Obtain a copy of the current documents specified by the `template_id` parameter. Returns a JSON object with a `data_uri` representing the base64 encoded file (PDFs only).

If the files are currently being prepared, a status code of `409` will be returned instead. In this case please wait for the `template_created` callback event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Template.TemplateFilesAsDataUri(new TemplateFilesAsDataUriRequest
    {
        TemplateId = "f57db65d3f933b5316d398057a36176831451a35",
    });
    // TODO: Handle 'response' of type FileResponseDataUri
}
catch (ApiException<TemplateFilesAsDataUriError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TemplateFilesAsDataUriRequest](src/DropboxSignApi/Requests/Template/TemplateFilesAsDataUriRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FileResponseDataUri](src/DropboxSignApi/Models/FileResponseDataUri.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TemplateFilesAsDataUriError](src/DropboxSignApi/Errors/TemplateFilesAsDataUriError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FileResponse&gt; TemplateFilesAsFileUrl(TemplateFilesAsFileUrlRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Obtain a copy of the current documents specified by the `template_id` parameter. Returns a JSON object with a url to the file (PDFs only).

If the files are currently being prepared, a status code of `409` will be returned instead. In this case please wait for the `template_created` callback event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Template.TemplateFilesAsFileUrl(new TemplateFilesAsFileUrlRequest
    {
        TemplateId = "f57db65d3f933b5316d398057a36176831451a35",
    });
    // TODO: Handle 'response' of type FileResponse
}
catch (ApiException<TemplateFilesAsFileUrlError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TemplateFilesAsFileUrlRequest](src/DropboxSignApi/Requests/Template/TemplateFilesAsFileUrlRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FileResponse](src/DropboxSignApi/Models/FileResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TemplateFilesAsFileUrlError](src/DropboxSignApi/Errors/TemplateFilesAsFileUrlError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TemplateGetResponse&gt; TemplateGet(TemplateGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the Template specified by the `template_id` parameter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Template.TemplateGet(new TemplateGetRequest
    {
        TemplateId = "f57db65d3f933b5316d398057a36176831451a35",
    });
    // TODO: Handle 'response' of type TemplateGetResponse
}
catch (ApiException<TemplateGetError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TemplateGetRequest](src/DropboxSignApi/Requests/Template/TemplateGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TemplateGetResponse](src/DropboxSignApi/Models/TemplateGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TemplateGetError](src/DropboxSignApi/Errors/TemplateGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TemplateListResponse&gt; TemplateList(TemplateListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of the Templates that are accessible by you.

Take a look at our [search guide](/api/reference/search/) to learn more about querying templates.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Template.TemplateList(new TemplateListRequest());
    // TODO: Handle 'response' of type TemplateListResponse
}
catch (ApiException<TemplateListError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TemplateListRequest](src/DropboxSignApi/Requests/Template/TemplateListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TemplateListResponse](src/DropboxSignApi/Models/TemplateListResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TemplateListError](src/DropboxSignApi/Errors/TemplateListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TemplateGetResponse&gt; TemplateRemoveUser(TemplateRemoveUserOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes the specified Account's access to the specified Template.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Template.TemplateRemoveUser(new TemplateRemoveUserOperationRequest
    {
        TemplateId = "f57db65d3f933b5316d398057a36176831451a35",
        Body = new TemplateRemoveUserRequest(),
    });
    // TODO: Handle 'response' of type TemplateGetResponse
}
catch (ApiException<TemplateRemoveUserError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TemplateRemoveUserOperationRequest](src/DropboxSignApi/Requests/Template/TemplateRemoveUserOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TemplateGetResponse](src/DropboxSignApi/Models/TemplateGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TemplateRemoveUserError](src/DropboxSignApi/Errors/TemplateRemoveUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TemplateUpdateFilesResponse&gt; TemplateUpdateFiles(TemplateUpdateFilesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Overlays a new file with the overlay of an existing template. The new file(s) must:

1. have the same or higher page count
2. the same orientation as the file(s) being replaced.

This will not overwrite or in any way affect the existing template. Both the existing template and new template will be available for use after executing this endpoint. Also note that this will decrement your template quota.

Overlaying new files is asynchronous and a successful call to this endpoint will return 200 OK response if the request passes initial validation checks.

It is recommended that a callback be implemented to listen for the callback event. A `template_created` event will be sent when the files are updated or a `template_error` event will be sent if there was a problem while updating the files. If a callback handler has been configured and the event has not been received within 60 minutes of making the call, check the status of the request in the API dashboard and retry the request if necessary.

If the page orientation or page count is different from the original template document, we will notify you with a `template_error` [callback event](https://app.hellosign.com/api/eventsAndCallbacksWalkthrough).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Template.TemplateUpdateFiles(new TemplateUpdateFilesOperationRequest
    {
        TemplateId = "f57db65d3f933b5316d398057a36176831451a35",
    });
    // TODO: Handle 'response' of type TemplateUpdateFilesResponse
}
catch (ApiException<TemplateUpdateFilesError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TemplateUpdateFilesOperationRequest](src/DropboxSignApi/Requests/Template/TemplateUpdateFilesOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TemplateUpdateFilesResponse](src/DropboxSignApi/Models/TemplateUpdateFilesResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[TemplateUpdateFilesError](src/DropboxSignApi/Errors/TemplateUpdateFilesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UnclaimedDraft

> Source: [UnclaimedDraft](src/DropboxSignApi/Api/UnclaimedDraft.cs)

<details>
<summary><code>Task&lt;UnclaimedDraftCreateResponse&gt; UnclaimedDraftCreate(UnclaimedDraftCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new Draft that can be claimed using the claim URL. The first authenticated user to access the URL will claim the Draft and will be shown either the "Sign and send" or the "Request signature" page with the Draft loaded. Subsequent access to the claim URL will result in a 404.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UnclaimedDraft.UnclaimedDraftCreate(new UnclaimedDraftCreateOperationRequest
    {
        Type = Type2.SendDocument,
    });
    // TODO: Handle 'response' of type UnclaimedDraftCreateResponse
}
catch (ApiException<UnclaimedDraftCreateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UnclaimedDraftCreateOperationRequest](src/DropboxSignApi/Requests/UnclaimedDraft/UnclaimedDraftCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UnclaimedDraftCreateResponse](src/DropboxSignApi/Models/UnclaimedDraftCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[UnclaimedDraftCreateError](src/DropboxSignApi/Errors/UnclaimedDraftCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UnclaimedDraftCreateResponse&gt; UnclaimedDraftCreateEmbedded(UnclaimedDraftCreateEmbeddedOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new Draft that can be claimed and used in an embedded iFrame. The first authenticated user to access the URL will claim the Draft and will be shown the "Request signature" page with the Draft loaded. Subsequent access to the claim URL will result in a `404`. For this embedded endpoint the `requester_email_address` parameter is required.

**NOTE:** Embedded unclaimed drafts can only be accessed in embedded iFrames whereas normal drafts can be used and accessed on Dropbox Sign.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UnclaimedDraft.UnclaimedDraftCreateEmbedded(
        new UnclaimedDraftCreateEmbeddedOperationRequest
        {
            ClientId = "some example string",
            RequesterEmailAddress = "user@example.com",
        });
    // TODO: Handle 'response' of type UnclaimedDraftCreateResponse
}
catch (ApiException<UnclaimedDraftCreateEmbeddedError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UnclaimedDraftCreateEmbeddedOperationRequest](src/DropboxSignApi/Requests/UnclaimedDraft/UnclaimedDraftCreateEmbeddedOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UnclaimedDraftCreateResponse](src/DropboxSignApi/Models/UnclaimedDraftCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[UnclaimedDraftCreateEmbeddedError](src/DropboxSignApi/Errors/UnclaimedDraftCreateEmbeddedError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UnclaimedDraftCreateResponse&gt; UnclaimedDraftCreateEmbeddedWithTemplate(UnclaimedDraftCreateEmbeddedWithTemplateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new Draft with a previously saved template(s) that can be claimed and used in an embedded iFrame. The first authenticated user to access the URL will claim the Draft and will be shown the "Request signature" page with the Draft loaded. Subsequent access to the claim URL will result in a `404`. For this embedded endpoint the `requester_email_address` parameter is required.

**NOTE:** Embedded unclaimed drafts can only be accessed in embedded iFrames whereas normal drafts can be used and accessed on Dropbox Sign.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UnclaimedDraft.UnclaimedDraftCreateEmbeddedWithTemplate(
        new UnclaimedDraftCreateEmbeddedWithTemplateOperationRequest
        {
            ClientId = "some example string",
            RequesterEmailAddress = "user@example.com",
            TemplateIds = ["some example string"],
        });
    // TODO: Handle 'response' of type UnclaimedDraftCreateResponse
}
catch (ApiException<UnclaimedDraftCreateEmbeddedWithTemplateError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UnclaimedDraftCreateEmbeddedWithTemplateOperationRequest](src/DropboxSignApi/Requests/UnclaimedDraft/UnclaimedDraftCreateEmbeddedWithTemplateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UnclaimedDraftCreateResponse](src/DropboxSignApi/Models/UnclaimedDraftCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[UnclaimedDraftCreateEmbeddedWithTemplateError](src/DropboxSignApi/Errors/UnclaimedDraftCreateEmbeddedWithTemplateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UnclaimedDraftCreateResponse&gt; UnclaimedDraftEditAndResend(UnclaimedDraftEditAndResendOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new signature request from an embedded request that can be edited prior to being sent to the recipients. Parameter `test_mode` can be edited prior to request. Signers can be edited in embedded editor. Requester's email address will remain unchanged if `requester_email_address` parameter is not set.

**NOTE:** Embedded unclaimed drafts can only be accessed in embedded iFrames whereas normal drafts can be used and accessed on Dropbox Sign.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UnclaimedDraft.UnclaimedDraftEditAndResend(
        new UnclaimedDraftEditAndResendOperationRequest
        {
            SignatureRequestId = "fa5c8a0b0f492d768749333ad6fcc214c111e967",
            Body = new UnclaimedDraftEditAndResendRequest { ClientId = "some example string" },
        });
    // TODO: Handle 'response' of type UnclaimedDraftCreateResponse
}
catch (ApiException<UnclaimedDraftEditAndResendError> ex)
{
    if (ex.Error.TryGetErrorResponseModel(out var error))
    {
        // TODO: Handle 'error' of type ErrorResponseModel
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UnclaimedDraftEditAndResendOperationRequest](src/DropboxSignApi/Requests/UnclaimedDraft/UnclaimedDraftEditAndResendOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UnclaimedDraftCreateResponse](src/DropboxSignApi/Models/UnclaimedDraftCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/DropboxSignApi/Core/Exceptions/ApiException.cs)&lt;[UnclaimedDraftEditAndResendError](src/DropboxSignApi/Errors/UnclaimedDraftEditAndResendError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

