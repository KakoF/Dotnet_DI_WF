using Data.Interfaces.DataConnector;
using Data.Repository;
using Domain.Entities;
using Domain.Interfaces.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class CustomerImplementation : Repository<Customer>, ICustomerImplementation
    {
        public CustomerImplementation(IDbConnector dbConnector) : base(dbConnector)
        {
        }

        protected override string InsertQuery => $"INSERT INTO [{nameof(Customer)}] ([{nameof(Customer.FirstName)}] ,([{nameof(Customer.LastName)}] ,([{nameof(Customer.City)}] ,[{nameof(Customer.Country)}] ,[{nameof(Customer.Phone)}]) VALUES (@{nameof(Customer.FirstName)}, @{nameof(Customer.LastName)}, @{nameof(Customer.City)}, @{nameof(Customer.Country)}, @{nameof(Customer.Phone)})";
        protected override string InsertQueryReturnInserted => $"INSERT INTO [{nameof(Customer)}] ([{nameof(Customer.FirstName)}] ,([{nameof(Customer.LastName)}] ,([{nameof(Customer.City)}] ,[{nameof(Customer.Country)}] ,[{nameof(Customer.Phone)}]) OUTPUT Inserted.* VALUES (@{nameof(Customer.FirstName)}, @{nameof(Customer.LastName)}, @{nameof(Customer.City)}, @{nameof(Customer.Country)}, @{nameof(Customer.Phone)})"; 
        protected override string UpdateByIdQuery => $"UPDATE [{nameof(Customer)}] SET {nameof(Customer.FirstName)} = @{nameof(Customer.FirstName)}, {nameof(Customer.LastName)} = @{nameof(Customer.LastName)}, {nameof(Customer.City)} = @{nameof(Customer.City)}, {nameof(Customer.Country)} = @{nameof(Customer.Country)}, {nameof(Customer.Phone)} = @{nameof(Customer.Phone)} WHERE {nameof(Customer.Id)} = @{nameof(Customer.Id)}";
        protected override string DeleteByIdQuery => $"DELETE FROM [{nameof(Customer)}] WHERE {nameof(Customer.Id)} = @{nameof(Customer.Id)}";
        protected override string SelectAllQuery => $"SELECT * FROM [{nameof(Customer)}]";
        protected override string SelectByIdQuery => $"SELECT * FROM [{nameof(Customer)}] WHERE {nameof(Customer.Id)} = @{nameof(Customer.Id)}";
    }
}
