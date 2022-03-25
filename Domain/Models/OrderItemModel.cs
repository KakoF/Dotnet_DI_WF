using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class OrderItemModel : BaseModel
    {
        public int OrderId { get; set; }
        public OrderModel Order { get; set; }
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
