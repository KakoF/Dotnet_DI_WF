using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Supplier : Base
    {
        public string CompanyName { get; private set; }
        public string ContactName { get; private set; }
        public string ContactTitle { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public string Phone { get; private set; }
        public string Fax { get; private set; }
    }
}
