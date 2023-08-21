using CustomerService.Command;
using CustomerService.Models;
using CustomerService.Validation;
using FluentValidation.TestHelper;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ServiceTest
{
    public class CustomerCommandValidatorTest
    {
        [Fact]
        public void CustomerCommandValidator_IfNameIsNullOrEmpty_ShouldThrowValidationException()
        {
            var validator = new CustomerCommandValidator();

            var customer = new Customer()
            {
                customerName = "",
            };

            var result = validator.TestValidate(customer);

            result.ShouldHaveValidationErrorFor(test => test.customerName);
        }

        [Fact]
        public void CustomerCommandValidator_IfCodeIsHaveDigit_ShouldThrowValidationException()
        {
            var validator = new CustomerCommandValidator();

            var customer = new Customer()
            {
                customerName = "test001",
            };

            var result = validator.TestValidate(customer);

            result.ShouldHaveValidationErrorFor(test => test.customerCode);
        }

        [Fact]
        public void CustomerCommandValidator_IfCodeIsNullOrEmpty_ShouldThrowValidationException()
        {
            var validator = new CustomerCommandValidator();

            var customer = new Customer()
            {
                customerCode = "",
            };

            var result = validator.TestValidate(customer);

            result.ShouldHaveValidationErrorFor(test => test.customerCode);
        }

        [Fact]
        public void CustomerCommandValidator_IfAddressIsNullOrEmpty_ShouldThrowValidationException()
        {
            var validator = new CustomerCommandValidator();

            var customer = new Customer()
            {
                customerAddress = "",
            };

            var result = validator.TestValidate(customer);

            result.ShouldHaveValidationErrorFor(test => test.customerAddress);
        }
    }
}
