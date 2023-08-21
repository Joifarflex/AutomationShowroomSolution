using CustomerService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Command
{
    public class InsertCustomerCommand : IRequest<Customer>
    {
        public Customer customer;

        public InsertCustomerCommand(Customer _customer)
        {
            customer = _customer;
        }
    }
}
