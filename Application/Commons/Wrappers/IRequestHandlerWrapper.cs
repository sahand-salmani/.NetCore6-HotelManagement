using Infrastructure.Commons.Response;
using MediatR;

namespace Application.Commons.Wrappers
{
    public interface IRequestHandlerWrapper<in TIn, TOut> : IRequestHandler<TIn, Response<TOut>>
        where TIn : IRequestWrapper<TOut>
    {
    }
}
