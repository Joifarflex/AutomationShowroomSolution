using AutoMapper;
using CustomerService.Command;
using CustomerService.Data;
using CustomerService.Models;
using CustomerService.Models.Dto;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController (IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Customer>> Get()
        {
            return await _mediator.Send(new GetAllCustomerCommand());
        }

        [HttpPost]
        public async Task<Customer> Post(Customer customer)
        {
            return await _mediator.Send(new InsertCustomerCommand(customer));
        }

        [HttpPut]
        public async Task<int> Put(Customer customer)
        {
            return await _mediator.Send(new UpdateCustomerCommand(customer.customerId, customer.customerCode, customer.customerName, customer.customerAddress, customer.createdBy, Convert.ToDateTime(customer.createdAt), customer.modifiedBy, Convert.ToDateTime(customer.modifiedAt)));
        }

        [HttpDelete]
        public async Task<int> Delete(int CustomerId)
        {
            return await _mediator.Send(new DeleteCustomerCommand() { CustomerId = CustomerId});
        }
    }
}
