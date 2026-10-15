using DropboxSignApi.Core.Authentication;
using DropboxSignApi.Core.Authentication.Basic;
using DropboxSignApi.Core.Authentication.Bearer;

namespace DropboxSignApi;

internal sealed class AuthSchemes
{
    public IAuthScheme ApiKey { get; }
    public IAuthScheme Oauth2 { get; }

    public AuthSchemes(DropboxSignApiClientOptions options)
    {
        ApiKey = BasicAuthScheme.Create(options.ApiKey);
        Oauth2 = BearerAuthScheme.Create(options.Oauth2);
    }
}
