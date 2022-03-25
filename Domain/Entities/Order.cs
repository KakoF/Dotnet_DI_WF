using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order : Base
    {
        public DateTime OrderDate { get; private set; }
        public string OrderNumber { get; private set; }
        public int CustomerId { get; private set; }
        public Customer Customer { get; private set; }
        public decimal TotalAmount { get; private set; }
    }
}
