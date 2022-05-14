using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SL.Services.Extensions;
namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
          // string translatedWord = "hola".Translate("es-AR");



            Customer customer = new Customer() { IdCustomer = Guid.NewGuid(), Name = "Gaston", BirthDate = new DateTime(1984,8,13) };

            //BLLAgregarCustomer(customer);

            try
            {
                BLL.Services.CustomerService.Current.Add(customer);
               
                Console.WriteLine("Cliente agregado con exito!! ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        //private static void BLLAgregarCustomer(Customer customer)
        //{            
        //    //IGenericRepository<Customer> repository = Factory.Current.GetCustomerRepository();

        //    //foreach (var item in repository.GetAll())
        //    //{
        //    //    Console.WriteLine(item.Name);
        //    //}
        //    Console.WriteLine("AGREGAMOS EL CUSTOMER");
        //    //repository.Add(customer);
        //    Console.WriteLine("TRAEMOS EL CUSTOMER");
        //    //var item = repository.GetById(customer.IdCustomer);
        //    Console.WriteLine(item.Name);
        //    Console.ReadLine();
        //    //foreach (var item in repository.GetAll())
        //    //{
        //    //    Console.WriteLine(item.Name);
        //    //}


        //    //System.Security.Cryptography

        //}
    }
}
