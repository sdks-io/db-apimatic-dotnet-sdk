using System;
using System.Collections.Generic;
using DropboxSignApi.Core.Authentication.Basic;
using DropboxSignApi.Core.Configuration;
using DropboxSignApi.Core.Hooks;
using DropboxSignApi.Servers;

namespace DropboxSignApi;

public class DropboxSignApiClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public TimeProvider TimeProvider { get; set; } = TimeProvider.System;
    public ServerOptions Server { get; set; } = new();
    /// <summary>
    /// Maximum time to wait for the next frame of a streaming (SSE) response before the stream is
    /// torn down with a timeout. Bounds only the wait for the server between frames, never the
    /// caller's own processing time. Set to null to wait indefinitely.
    /// </summary>
    public TimeSpan? StreamReadTimeout { get; set; } = TimeSpan.FromSeconds(60);
    public IReadOnlyList<SdkHook> Hooks { get; set; } = [];
    /// <summary>
    /// Your API key can be used to make calls to the Dropbox Sign API. See <see href="/api/reference/authentication">Authentication</see> for more information.
    /// ✅ Supported by Try it console (calls sent in <c>test_mode</c> only).
    /// </summary>
    public BasicAuthCredentials? ApiKey { get; set; }
    /// <summary>
    /// You can use an Access Token issued through an OAuth flow to send calls to the Dropbox Sign API from your app. The access scopes required by this endpoint are listed in the gray box above. See <see href="/api/reference/authentication">Authentication</see> for more information.
    /// ❌ <b>Not supported</b> by Try it console.
    /// </summary>
    public string? Oauth2 { get; set; }
}
