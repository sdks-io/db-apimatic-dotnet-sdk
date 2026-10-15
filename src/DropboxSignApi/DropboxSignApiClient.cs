using System.Net.Http;
using DropboxSignApi.Api;
using DropboxSignApi.Core;
using DropboxSignApi.Core.Logging;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi;

/// <summary>
/// Dropbox Sign v3 API
/// </summary>
public sealed class DropboxSignApiClient
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    public DropboxSignApiClient(HttpClient httpClient, DropboxSignApiClientOptions options)
    {
        _server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory = new HeadersFactory([
            new HeaderParam("User-Agent", "DropboxSignApiClient/3.0.0 CSharp"),
            new HeaderParam("X-APIMatic-Lang", "CSharp"),
            new HeaderParam("X-APIMatic-Package-Version", "3.0.0"),
            new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
            new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
            new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime),
        ]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry, options.TimeProvider);
        var httpLogger = new HttpLogger(options.Logging, "DropboxSignApiClient", options.TimeProvider);
        var responseContexts = new ResponseContextFactory(options.TimeProvider, options.StreamReadTimeout);
        _rawClient =
            new RawClient(
                httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks,
                responseContexts);
        _auth = new AuthSchemes(options);
    }

    public Account Account => field ??= new Account(_rawClient, _server, _auth);

    public ApiApp ApiApp => field ??= new ApiApp(_rawClient, _server, _auth);

    public BulkSendJob BulkSendJob => field ??= new BulkSendJob(_rawClient, _server, _auth);

    public Document Document => field ??= new Document(_rawClient, _server, _auth);

    public Embedded Embedded => field ??= new Embedded(_rawClient, _server, _auth);

    public Fax Fax => field ??= new Fax(_rawClient, _server, _auth);

    public FaxLine FaxLine => field ??= new FaxLine(_rawClient, _server, _auth);

    public OAuth OAuth => field ??= new OAuth(_rawClient, _server);

    public Report Report => field ??= new Report(_rawClient, _server, _auth);

    public SignatureRequest SignatureRequest => field ??= new SignatureRequest(_rawClient, _server, _auth);

    public Team Team => field ??= new Team(_rawClient, _server, _auth);

    public Template Template => field ??= new Template(_rawClient, _server, _auth);

    public UnclaimedDraft UnclaimedDraft => field ??= new UnclaimedDraft(_rawClient, _server, _auth);
}
