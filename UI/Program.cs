using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SL.Services.Extensions;
using System.Threading;
using System.Globalization;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //SEGURIDAD -> LOGIN, USUARIO-ROLES-PERMISOS



            Clase13052022();
        }

        private static void Clase13052022()
        {
            Console.WriteLine(Thread.CurrentThread.CurrentUICulture.Name);

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-AR");

            Console.WriteLine(Thread.CurrentThread.CurrentUICulture.Name);

            string translatedWordEspañol = "hola".Translate();

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");

            string translatedWordIngles = "hola".Translate();

            string encryptedString = SL.Services.CryptographyService.EncryptString("hola", "frase");

            string decryptedString = SL.Services.CryptographyService.DecryptString(encryptedString, "frase");

            string hashedString = SL.Services.CryptographyService.Hash("BrianSeVaACordoba2022.;");

            Customer customer = new Customer() { IdCustomer = Guid.NewGuid(), Name = "Gaston", BirthDate = new DateTime(1984, 8, 13) };

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
