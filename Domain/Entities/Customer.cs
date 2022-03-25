using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customer : Base
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public string Phone{ get; private set; }
    }
}
