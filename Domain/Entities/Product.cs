using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product : Base
    {
        public string ProductName { get; private set; }
        public int SupplierId { get; private set; }
        public Supplier Supplier { get; private set; }
        public decimal UnitPrice { get; private set; }
        public string Package { get; private set; }
        public int Stock { get; private set; }
        public bool IsDiscontinued { get; private set; }
    }
}
