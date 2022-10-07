using Infrastructure.Commons.Response;
using MediatR;

namespace Application.Commons.Wrappers
{
    public interface IRequestWrapper<TOut> : IRequest<Response<TOut>>
    {
    }
}
