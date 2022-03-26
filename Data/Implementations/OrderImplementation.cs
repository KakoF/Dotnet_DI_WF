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
    public class OrderImplementation : Repository<Order>, IOrderImplementation
    {
        public OrderImplementation(IDbConnector dbConnector) : base(dbConnector)
        {
        }

        protected override string InsertQuery => $"INSERT INTO [{nameof(Order)}] ([{nameof(Order.OrderDate)}] ,([{nameof(Order.OrderNumber)}] ,([{nameof(Order.CustomerId)}] ,[{nameof(Order.Customer)}] ) VALUES (@{nameof(Order.OrderDate)}, @{nameof(Order.OrderNumber)}, @{nameof(Order.CustomerId)}, @{nameof(Order.TotalAmount)})";
        protected override string InsertQueryReturnInserted => $"INSERT INTO [{nameof(Order)}] ([{nameof(Order.OrderDate)}] ,([{nameof(Order.OrderNumber)}] ,([{nameof(Order.CustomerId)}] ,[{nameof(Order.Customer)}]) OUTPUT Inserted.* VALUES (@{nameof(Order.OrderDate)}, @{nameof(Order.OrderNumber)}, @{nameof(Order.CustomerId)}, @{nameof(Order.TotalAmount)})";
        protected override string UpdateByIdQuery => $"UPDATE [{nameof(Order)}] SET {nameof(Order.OrderDate)} = @{nameof(Order.OrderDate)}, {nameof(Order.OrderNumber)} = @{nameof(Order.OrderNumber)}, {nameof(Order.CustomerId)} = @{nameof(Order.CustomerId)}, {nameof(Order.Customer)} = @{nameof(Order.Customer)} WHERE {nameof(Order.Id)} = @{nameof(Order.Id)}";
        protected override string DeleteByIdQuery => $"DELETE FROM [{nameof(Order)}] WHERE {nameof(Order.Id)} = @{nameof(Order.Id)}";
        protected override string SelectAllQuery => $"SELECT * FROM [{nameof(Order)}]";
        protected override string SelectByIdQuery => $"SELECT * FROM [{nameof(Order)}] WHERE {nameof(Order.Id)} = @{nameof(Order.Id)}";
    }
}
