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
    public class ProductImplementation : Repository<Product>, IProductImplementation
    {
        public ProductImplementation(IDbConnector dbConnector) : base(dbConnector)
        {
        }

        protected override string InsertQuery => $"INSERT INTO [{nameof(Product)}] ([{nameof(Product.ProductName)}] ,([{nameof(Product.SupplierId)}] ,([{nameof(Product.UnitPrice)}] ,[{nameof(Product.Package)}] ,[{nameof(Product.Stock)}], [{nameof(Product.IsDiscontinued)}]) VALUES (@{nameof(Product.ProductName)}, @{nameof(Product.SupplierId)}, @{nameof(Product.UnitPrice)}, @{nameof(Product.Package)}, @{nameof(Product.Stock)}, @{nameof(Product.IsDiscontinued)})";
        protected override string InsertQueryReturnInserted => $"INSERT INTO [{nameof(Product)}] ([{nameof(Product.ProductName)}] ,([{nameof(Product.SupplierId)}] ,([{nameof(Product.UnitPrice)}] ,[{nameof(Product.Package)}] ,[{nameof(Product.Stock)}], [{nameof(Product.IsDiscontinued)}]) OUTPUT Inserted.* VALUES (@{nameof(Product.ProductName)}, @{nameof(Product.SupplierId)}, @{nameof(Product.UnitPrice)}, @{nameof(Product.Package)}, @{nameof(Product.Stock)}, @{nameof(Product.IsDiscontinued)})";
        protected override string UpdateByIdQuery => $"UPDATE [{nameof(Product)}] SET {nameof(Product.ProductName)} = @{nameof(Product.ProductName)}, {nameof(Product.SupplierId)} = @{nameof(Product.SupplierId)}, {nameof(Product.UnitPrice)} = @{nameof(Product.UnitPrice)}, {nameof(Product.Package)} = @{nameof(Product.Package)}, {nameof(Product.Stock)} = @{nameof(Product.Stock)}, {nameof(Product.IsDiscontinued)} = @{nameof(Product.IsDiscontinued)} WHERE {nameof(Product.Id)} = @{nameof(Product.Id)}";
        protected override string DeleteByIdQuery => $"DELETE FROM [{nameof(Product)}] WHERE {nameof(Product.Id)} = @{nameof(Product.Id)}";
        protected override string SelectAllQuery => $"SELECT * FROM [{nameof(Product)}]";
        protected override string SelectByIdQuery => $"SELECT * FROM [{nameof(Product)}] WHERE {nameof(Product.Id)} = @{nameof(Product.Id)}";
    }
}
