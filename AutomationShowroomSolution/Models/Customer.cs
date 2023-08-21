using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Models
{
    public class Customer
    {
        [Key]
        public int customerId { get; set; }
        public string customerCode { get; set; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public int createdBy { get; set; }
        public DateTime? createdAt { get; set; }
        public int modifiedBy { get; set; }
        public DateTime? modifiedAt { get; set; }
    }
}
