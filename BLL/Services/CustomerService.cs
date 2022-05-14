using BLL.BussinessExceptions;
using BLL.Contracts;
using DAL.Factory;
using DomainModel;
using SL.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{

    public sealed class CustomerService : IGenericBLLRepository<Customer>
    {
        private readonly static CustomerService  _instance = new CustomerService();

        public static CustomerService  Current
        {
            get
            {
                return _instance;
            }
        }

        private CustomerService()
        {
            //Implent here the initialization of your singleton
        }

        public void Add(Customer obj)
        {
            try
            {
                //Validar si el cliente es mayor de edad

                if (obj.BirthDate > DateTime.Now.AddYears(-18))
                    throw new ClienteMayorDeEdadException();

                Factory.Current.GetCustomerRepository().Add(obj);
            }
            catch (ClienteMayorDeEdadException ex)
            {
                ex.Handle(this);
            }
            catch(Exception ex)
            {
                ex.Handle(this);
            }
        }

        public void Update(Customer obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Customer GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }
    }

}
