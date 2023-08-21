using CustomerService.Command;
using CustomerService.Data;
using CustomerService.Handler;
using CustomerService.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace ServiceTest.HandlerTest
{
    public class InsertCustomerHandlerTest
    {
        private readonly Mock<AppDbContext> _dbMock;

        [Fact]
        public void customerNotBeNull()
        {
            var customer = new Customer()
            {
                customerId = 1,
                customerCode = "test01",
                customerName = "test",
                customerAddress = "test",
                createdAt = DateTime.Now,
                createdBy = 1,
                modifiedAt = DateTime.Now,
                modifiedBy = 1,
            };

            var handler = new InsertCustomerHandler(_dbMock.Object);

            Assert.NotNull(handler);
        }
    }
}
