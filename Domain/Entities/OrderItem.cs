using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderItem : Base
    {
        public int OrderId { get; private set; }
        public Order Order { get; private set; }
        public int ProductId { get; private set; }
        public Product Product { get; private set; }
        public decimal UnitPrice { get; private set; }
        public int Quantity { get; private set; }
    }
}
