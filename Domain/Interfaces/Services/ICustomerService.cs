using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface ICustomerService
    {
        Task<CustomerModel> ReadAsync(int id);
        Task<IEnumerable<CustomerModel>> ReadAsync();
        Task<CustomerModel> CreateAsync(CustomerModel data);
        Task<CustomerModel> UpdateAsync(int id, CustomerModel data);
        Task<bool> DeleteAsync(int id);
    }
}
