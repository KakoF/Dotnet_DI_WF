using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class OrderModel : BaseModel
    {
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public CustomerModel Customer { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
