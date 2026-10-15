using System.Threading;
using System.Threading.Tasks;
using DropboxSignApi.Core.Models;

namespace DropboxSignApi.Core.ErrorResponse;

internal interface IErrorResponse<TError>
{
    Task<TError> Map(ResponseContext context, CancellationToken cancellationToken);
}