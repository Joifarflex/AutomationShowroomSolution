﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Interface
{
    public interface IRequestWrapper<T> : IRequest<T>
    {
    }
}
