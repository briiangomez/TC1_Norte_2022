using DAL.Contracts;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Factory
{

    public sealed class Factory
    {
        #region Singleton
        private readonly static Factory _instance = new Factory();

        public static Factory Current
        {
            get
            {
                return _instance;
            }
        }

        private Factory()
        {
            //Implement here the initialization code
        }
        #endregion

        private string dataSource = ConfigurationManager.AppSettings["datasource"];
        public IGenericRepository<Customer> GetCustomerRepository()
        {
            if(dataSource == "sqlserver")
                return new DAL.Implementations.SqlServer.CustomerRepository();
            else if(dataSource == "memory")
                return new DAL.Implementations.Memory.CustomerRepository();

            return null;
        }
    }

}
