using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task<ProductModel> ReadAsync(int id);
        Task<IEnumerable<ProductModel>> ReadAsync();
        Task<ProductModel> CreateAsync(ProductModel data);
        Task<ProductModel> UpdateAsync(int id, ProductModel data);
        Task<bool> DeleteAsync(int id);
    }
}
