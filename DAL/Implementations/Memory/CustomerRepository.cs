using DAL.Contracts;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.Memory
{
    internal class CustomerRepository : IGenericRepository<Customer>
    {
        private List<Customer> customers = new List<Customer>();

        public CustomerRepository()
        {
            customers.Add(new Customer() { Name = "Guille" });
            customers.Add(new Customer() { Name = "Brian" });
            customers.Add(new Customer() { Name = "Ignacio" });
        }
        public void Add(Customer obj)
        {
            customers.Add(obj);
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            return customers;
        }

        public Customer GetById(Guid id)
        {
            return customers.Where(o => o.IdCustomer == id).FirstOrDefault();
        }

        public void Update(Customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
