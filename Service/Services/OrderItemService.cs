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
    public class OrderItemService : IOrderItemService
    {
        private readonly IOrderItemImplementation _implementation;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public OrderItemService(IOrderItemImplementation implementation, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _implementation = implementation;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<OrderItemModel> CreateAsync(OrderItemModel data)
        {
            try
            {
                var entity = _mapper.Map<OrderItem>(data);
                _unitOfWork.BeginTransaction();
                var result = await _implementation.CreateAsync(entity);
                _unitOfWork.CommitTransaction();
                return _mapper.Map<OrderItemModel>(result);
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

        public async Task<OrderItemModel> ReadAsync(int id)
        {
            var entity = await _implementation.ReadAsync(id);
            var OrderItem = _mapper.Map<OrderItemModel>(entity);
            return OrderItem;
        }

        public async Task<IEnumerable<OrderItemModel>> ReadAsync()
        {
            var list = await _implementation.ReadAsync();
            return _mapper.Map<IEnumerable<OrderItemModel>>(list);
        }

        public async Task<OrderItemModel> UpdateAsync(int id, OrderItemModel data)
        {
            var entity = await _implementation.ReadAsync(id);
            if (entity == null)
                return null;

            try
            {
                var model = _mapper.Map<OrderItemModel>(entity);
                _mapper.Map(data, model);
                _mapper.Map(model, entity);
                var result = await _implementation.UpdateAsync(id, entity);
                _unitOfWork.CommitTransaction();
                return _mapper.Map<OrderItemModel>(result);
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
