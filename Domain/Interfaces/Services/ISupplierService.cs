using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface ISupplierService
    {
        Task<SupplierModel> ReadAsync(int id);
        Task<IEnumerable<SupplierModel>> ReadAsync();
        Task<SupplierModel> CreateAsync(SupplierModel data);
        Task<SupplierModel> UpdateAsync(int id, SupplierModel data);
        Task<bool> DeleteAsync(int id);
    }
}
