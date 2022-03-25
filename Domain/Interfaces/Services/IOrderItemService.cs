using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IOrderItemService
    {
        Task<OrderItemModel> ReadAsync(int id);
        Task<IEnumerable<OrderItemModel>> ReadAsync();
        Task<OrderItemModel> CreateAsync(OrderItemModel data);
        Task<OrderItemModel> UpdateAsync(int id, OrderItemModel data);
        Task<bool> DeleteAsync(int id);
    }
}
