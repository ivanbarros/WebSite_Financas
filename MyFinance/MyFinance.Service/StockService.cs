using Microsoft.AspNetCore.Http;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using MyFinance.Service.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Service
{
    public class StockService : IStockService
    {
        public IHttpContextAccessor _HttpContextAccessor { get; set; }
        private readonly IStockRepository _repository;

        public StockService(IHttpContextAccessor httpContextAccessor, IStockRepository repository)
        {
            _HttpContextAccessor = httpContextAccessor;
            _repository = repository;
        }

        public Task<IEnumerable<StockEntity>> GetAll()
        {
            var result = _repository.GetAll();
            return result;
        }

        public void Insert(StockEntity item)
        {
            _repository.Add(item);
        }

        public void Excluir(int id)
        {
            _repository.Delete(id);
        }

        public Task<StockEntity> Update(StockEntity item)
        {
            throw new NotImplementedException();
        }

        public StockEntity Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
