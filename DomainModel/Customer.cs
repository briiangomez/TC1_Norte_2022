using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Customer
    {
        public Guid IdCustomer { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
