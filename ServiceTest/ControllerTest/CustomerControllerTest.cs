using CustomerService.Command;
using CustomerService.Data;
using CustomerService.Handler;
using CustomerService.Models;
using MediatR;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace ServiceTest.CommandTest
{
    public class CustomerControllerTest
    {
        public Mock<IMediator> _mediator;
        public Mock<AppDbContext> _dbMock;

        [Fact]
        public async Task InsertCustomerTest_IsValueNull()
        {
            var customer = new Customer()
            {
                customerId = 0,
                customerCode = "",
                customerName = "",
                customerAddress = "",
                createdAt = null,
                createdBy = 0,
                modifiedAt = null,
                modifiedBy = 0,
            };

            _mediator.Setup(x => x.Send(It.IsAny<Customer>(), It.IsAny<CancellationToken>()));

            var command = new InsertCustomerCommand(customer);

            var handler = new InsertCustomerHandler(_dbMock.Object);

            var getException = await Assert.ThrowsAsync<Exception>(() => handler.Handle(command, CancellationToken.None));

            Assert.IsType<Exception>(getException);
        }
    }
}
