using DAL.Contracts;
using DAL.Tools;
using DomainModel;
using SL.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.SqlServer
{

    

    internal class CustomerRepository : IGenericRepository<Customer>
    {
        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Customer] (IdCustomer,Name,BirthDate) VALUES (@IdCustomer,@Name,@BirthDate)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Customer] SET () WHERE  = @";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Customer] WHERE  = @";
        }

        private string SelectOneStatement
        {
            get => "SELECT IdCustomer,Name,BirthDate  FROM [dbo].[Customer] WHERE IdCustomer  = @IdCustomer";
        }

        private string SelectAllStatement
        {
            get => "SELECT IdCustomer,Name,BirthDate  FROM [dbo].[Customer]";
        }
        #endregion
        public void Add(Customer ojb)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                    {
                new SqlParameter("@IdCustomer", ojb.IdCustomer),
                new SqlParameter("@Name",ojb.Name),
                new SqlParameter("@BirthDate",ojb.BirthDate)
                    };

                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text, parameters);
            }
            catch (Exception ex)
            {
                ex.Handle(this);
            }
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(Guid id)
        {
            Customer customer = null;

            using (var reader = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text,
                new SqlParameter[] { new SqlParameter("@IdCustomer", id) }))
            {
                if(reader.Read())
                {
                    object[] values = new object[reader.FieldCount];
                    reader.GetValues(values);
                    customer = new Customer();
                    customer.IdCustomer = Guid.Parse(values[0].ToString());
                    customer.Name = values[1].ToString();
                    customer.BirthDate = DateTime.Parse(values[2].ToString());
                } 
            }

            return customer;
        }

        public void Update(Customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
