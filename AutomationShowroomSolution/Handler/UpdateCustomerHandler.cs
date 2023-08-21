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
    public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerCommand, int>
    {
        private readonly AppDbContext _db;

        public UpdateCustomerHandler(AppDbContext db)
        {
            _db = db;
        }

        public async Task<int> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var getCustomer = _db.Customers.Where(d => d.customerId == request.CustomerId).First();

            getCustomer.customerName = request.CustomerName;
            getCustomer.customerCode = request.CustomerCode;
            getCustomer.customerAddress = request.CustomerAddress;
            getCustomer.createdAt = request.CreatedAt;
            getCustomer.createdBy = request.CreatedBy;
            getCustomer.modifiedAt = request.ModifiedAt;
            getCustomer.modifiedBy = request.ModifiedBy;

            _db.Customers.Update(getCustomer);
            _db.SaveChanges();

            return await Task.FromResult(getCustomer.customerId);

        }
    }
}
