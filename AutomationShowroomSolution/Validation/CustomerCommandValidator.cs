using CustomerService.Command;
using CustomerService.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Validation
{
    public class CustomerCommandValidator : AbstractValidator<Customer>
    {
        public CustomerCommandValidator()
        {
            RuleFor(d => d.customerName)
                .NotEmpty()
                .Matches(@"^[A-Za-z\s]*$");
            RuleFor(d => d.customerCode).NotEmpty();
            RuleFor(d => d.customerAddress).NotEmpty();
            RuleFor(d => d.createdAt).NotEmpty();
            RuleFor(d => d.createdBy).NotEmpty();
            RuleFor(d => d.modifiedAt).NotEmpty();
            RuleFor(d => d.modifiedBy).NotEmpty();
        }
    }
}
