using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IOrderService
    {
        Task<OrderModel> ReadAsync(int id);
        Task<IEnumerable<OrderModel>> ReadAsync();
        Task<OrderModel> CreateAsync(OrderModel data);
        Task<OrderModel> UpdateAsync(int id, OrderModel data);
        Task<bool> DeleteAsync(int id);
    }
}
