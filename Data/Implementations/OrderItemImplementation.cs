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
    public class OrderItemItemImplementation : Repository<OrderItem>, IOrderItemImplementation
    {
        public OrderItemItemImplementation(IDbConnector dbConnector) : base(dbConnector)
        {
        }

        protected override string InsertQuery => $"INSERT INTO [{nameof(OrderItem)}] ([{nameof(OrderItem.OrderId)}] ,([{nameof(OrderItem.ProductId)}] ,([{nameof(OrderItem.UnitPrice)}] ,[{nameof(OrderItem.Quantity)}] ) VALUES (@{nameof(OrderItem.OrderId)}, @{nameof(OrderItem.ProductId)}, @{nameof(OrderItem.UnitPrice)}, @{nameof(OrderItem.Quantity)})";
        protected override string InsertQueryReturnInserted => $"INSERT INTO [{nameof(OrderItem)}] ([{nameof(OrderItem.OrderId)}] ,([{nameof(OrderItem.ProductId)}] ,([{nameof(OrderItem.UnitPrice)}] ,[{nameof(OrderItem.Quantity)}]) OUTPUT Inserted.* VALUES (@{nameof(OrderItem.OrderId)}, @{nameof(OrderItem.ProductId)}, @{nameof(OrderItem.UnitPrice)}, @{nameof(OrderItem.Quantity)})";
        protected override string UpdateByIdQuery => $"UPDATE [{nameof(OrderItem)}] SET {nameof(OrderItem.OrderId)} = @{nameof(OrderItem.OrderId)}, {nameof(OrderItem.ProductId)} = @{nameof(OrderItem.ProductId)}, {nameof(OrderItem.UnitPrice)} = @{nameof(OrderItem.UnitPrice)}, {nameof(OrderItem.Quantity)} = @{nameof(OrderItem.Quantity)} WHERE {nameof(OrderItem.Id)} = @{nameof(OrderItem.Id)}";
        protected override string DeleteByIdQuery => $"DELETE FROM [{nameof(OrderItem)}] WHERE {nameof(OrderItem.Id)} = @{nameof(OrderItem.Id)}";
        protected override string SelectAllQuery => $"SELECT * FROM [{nameof(OrderItem)}]";
        protected override string SelectByIdQuery => $"SELECT * FROM [{nameof(OrderItem)}] WHERE {nameof(OrderItem.Id)} = @{nameof(OrderItem.Id)}";
    }
}
