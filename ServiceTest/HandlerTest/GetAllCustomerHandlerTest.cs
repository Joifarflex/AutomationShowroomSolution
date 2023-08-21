using CustomerService.Data;
using CustomerService.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace ServiceTest.HandlerTest
{
    public class GetAllCustomerHandlerTest
    {
        private readonly Mock<AppDbContext> _dbMock;

        [Fact]
        public void GetAllCustomerTest()
        {
            var handler = new GetAllCustomerHandlerTest();

            Assert.NotNull(handler);
        }


    }
}
