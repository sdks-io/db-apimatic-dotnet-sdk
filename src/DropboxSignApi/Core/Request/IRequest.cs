using System.Net.Http;

namespace DropboxSignApi.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}