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
    public class SupplierImplementation : Repository<Supplier>, ISupplierImplementation
    {
        public SupplierImplementation(IDbConnector dbConnector) : base(dbConnector)
        {
        }

       

        protected override string InsertQuery => $"INSERT INTO [{nameof(Supplier)}] ([{nameof(Supplier.CompanyName)}] ,([{nameof(Supplier.ContactName)}] ,([{nameof(Supplier.ContactTitle)}] ,[{nameof(Supplier.City)}] ,[{nameof(Supplier.Country)}], [{nameof(Supplier.Phone)}], [{nameof(Supplier.Fax)}]) VALUES (@{nameof(Supplier.CompanyName)}, @{nameof(Supplier.ContactName)}, @{nameof(Supplier.ContactTitle)}, @{nameof(Supplier.City)}, @{nameof(Supplier.Country)}, @{nameof(Supplier.Phone)}, @{nameof(Supplier.Fax)})";
        protected override string InsertQueryReturnInserted => $"INSERT INTO [{nameof(Supplier)}] ([{nameof(Supplier.CompanyName)}] ,([{nameof(Supplier.ContactName)}] ,([{nameof(Supplier.ContactTitle)}] ,[{nameof(Supplier.City)}] ,[{nameof(Supplier.Country)}], [{nameof(Supplier.Phone)}], [{nameof(Supplier.Fax)}])  OUTPUT Inserted.* VALUES (@{nameof(Supplier.CompanyName)}, @{nameof(Supplier.ContactName)}, @{nameof(Supplier.ContactTitle)}, @{nameof(Supplier.City)}, @{nameof(Supplier.Country)}, @{nameof(Supplier.Phone)}, @{nameof(Supplier.Fax)})";
        protected override string UpdateByIdQuery => $"UPDATE [{nameof(Supplier)}] SET {nameof(Supplier.CompanyName)} = @{nameof(Supplier.CompanyName)}, {nameof(Supplier.ContactName)} = @{nameof(Supplier.ContactName)}, {nameof(Supplier.ContactTitle)} = @{nameof(Supplier.ContactTitle)}, {nameof(Supplier.City)} = @{nameof(Supplier.City)}, {nameof(Supplier.Country)} = @{nameof(Supplier.Country)}, {nameof(Supplier.Phone)} = @{nameof(Supplier.Phone)}, {nameof(Supplier.Fax)} = @{nameof(Supplier.Fax)} WHERE {nameof(Supplier.Id)} = @{nameof(Supplier.Id)}";
        protected override string DeleteByIdQuery => $"DELETE FROM [{nameof(Supplier)}] WHERE {nameof(Supplier.Id)} = @{nameof(Supplier.Id)}";
        protected override string SelectAllQuery => $"SELECT * FROM [{nameof(Supplier)}]";
        protected override string SelectByIdQuery => $"SELECT * FROM [{nameof(Supplier)}] WHERE {nameof(Supplier.Id)} = @{nameof(Supplier.Id)}";
    }
}
