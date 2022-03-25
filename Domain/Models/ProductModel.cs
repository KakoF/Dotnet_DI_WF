using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProductModel : BaseModel
    {
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public SupplierModel Supplier { get; set; }
        public decimal UnitPrice { get; set; }
        public string Package { get; set; }
        public int Stock { get; set; }
        public bool IsDiscontinued { get; set; }
    }
}
