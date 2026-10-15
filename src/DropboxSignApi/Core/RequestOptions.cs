using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using DropboxSignApi.Core.Hooks;

namespace DropboxSignApi.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
