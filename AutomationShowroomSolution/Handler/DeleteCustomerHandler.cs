using CustomerService.Command;
using CustomerService.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerService.Handler
{
    public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerCommand, int>
    {
        private readonly AppDbContext _db;
        public DeleteCustomerHandler(AppDbContext db)
        {
            _db = db;
        }

        public Task<int> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var getCustomer = _db.Customers.Where(d => d.customerId == request.CustomerId).FirstOrDefault();
            _db.Customers.Remove(getCustomer);
            _db.SaveChanges();

            return Task.FromResult(request.CustomerId);
        }
    }
}
