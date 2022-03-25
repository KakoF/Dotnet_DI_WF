using AutoMapper;
using Data.Interfaces.DataConnector;
using Domain.Entities;
using Domain.Interfaces.Implementations;
using Domain.Interfaces.Services;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductImplementation _implementation;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IProductImplementation implementation, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _implementation = implementation;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<ProductModel> CreateAsync(ProductModel data)
        {
            try
            {
                var entity = _mapper.Map<Product>(data);
                _unitOfWork.BeginTransaction();
                var result = await _implementation.CreateAsync(entity);
                _unitOfWork.CommitTransaction();
                return _mapper.Map<ProductModel>(result);
            }
            catch
            {
                _unitOfWork.RollbackTransaction();
                throw;
            }
            finally
            {
                _unitOfWork.Dispose();
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var delete = await _implementation.DeleteAsync(id);
            return delete;
        }

        public async Task<ProductModel> ReadAsync(int id)
        {
            var entity = await _implementation.ReadAsync(id);
            var Product = _mapper.Map<ProductModel>(entity);
            return Product;
        }

        public async Task<IEnumerable<ProductModel>> ReadAsync()
        {
            var list = await _implementation.ReadAsync();
            return _mapper.Map<IEnumerable<ProductModel>>(list);
        }

        public async Task<ProductModel> UpdateAsync(int id, ProductModel data)
        {
            var entity = await _implementation.ReadAsync(id);
            if (entity == null)
                return null;

            try
            {
                var model = _mapper.Map<ProductModel>(entity);
                _mapper.Map(data, model);
                _mapper.Map(model, entity);
                var result = await _implementation.UpdateAsync(id, entity);
                _unitOfWork.CommitTransaction();
                return _mapper.Map<ProductModel>(result);
            }
            catch
            {
                _unitOfWork.RollbackTransaction();
                throw;
            }
            finally
            {
                _unitOfWork.Dispose();
            }
        }
    }
}
