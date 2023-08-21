using CustomerService.Command;
using CustomerService.Data;
using CustomerService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerService.Handler
{
    public class InsertCustomerHandler : IRequestHandler<InsertCustomerCommand, Customer>
    {
        private readonly AppDbContext _db;

        public InsertCustomerHandler(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Customer> Handle(InsertCustomerCommand request, CancellationToken cancellationToken)
        {
            _db.Customers.Add(request.customer);
            _db.SaveChanges();

            return await Task.FromResult(request.customer);
        }
    }
}
