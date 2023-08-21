using CustomerService.Data;
using CustomerService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Command
{
    public class GetAllCustomerCommand : IRequest<List<Customer>>
    {
        public GetAllCustomerCommand()
        {

        }
    }
}
