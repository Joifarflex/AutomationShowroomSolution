using CustomerService.Models;
using CustomerService.Models.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Command
{
    public class UpdateCustomerCommand : IRequest<int>
    {
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }

        public UpdateCustomerCommand(int customerId, string customerCode, string customerName, string customerAddress, int createdBy, DateTime createdAt, int modifiedBy, DateTime modifiedAt)
        {
            CustomerId = customerId;
            CustomerCode = customerCode;
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            CreatedBy = createdBy;
            CreatedAt = createdAt;
            ModifiedBy = modifiedBy;
            ModifiedAt = modifiedAt;
        }
    }
}
