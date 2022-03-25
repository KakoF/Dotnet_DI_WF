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
    public class OrderService : IOrderService
    {
        private readonly IOrderImplementation _implementation;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IOrderImplementation implementation, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _implementation = implementation;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<OrderModel> CreateAsync(OrderModel data)
        {
            try
            {
                var entity = _mapper.Map<Order>(data);
                _unitOfWork.BeginTransaction();
                var result = await _implementation.CreateAsync(entity);
                _unitOfWork.CommitTransaction();
                return _mapper.Map<OrderModel>(result);
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

        public async Task<OrderModel> ReadAsync(int id)
        {
            var entity = await _implementation.ReadAsync(id);
            var Order = _mapper.Map<OrderModel>(entity);
            return Order;
        }

        public async Task<IEnumerable<OrderModel>> ReadAsync()
        {
            var list = await _implementation.ReadAsync();
            return _mapper.Map<IEnumerable<OrderModel>>(list);
        }

        public async Task<OrderModel> UpdateAsync(int id, OrderModel data)
        {
            var entity = await _implementation.ReadAsync(id);
            if (entity == null)
                return null;

            try
            {
                var model = _mapper.Map<OrderModel>(entity);
                _mapper.Map(data, model);
                _mapper.Map(model, entity);
                var result = await _implementation.UpdateAsync(id, entity);
                _unitOfWork.CommitTransaction();
                return _mapper.Map<OrderModel>(result);
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
