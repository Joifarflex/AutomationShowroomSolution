using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Models.Dto
{
    public class ResponseDto
    {
        public string Message { get; set; } = ""; //set default empty message
        public object? Data { get; set; }
    }
}
