using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Interface
{
    public interface IRequestHandlerWrapper<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
        where TRequest : IRequestWrapper<TResponse>
    {
    }
}
