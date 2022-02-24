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
    public class SalesService : ISalesService
    {
        public IHttpContextAccessor _HttpContextAccessor { get; set; }
        private readonly ISalesRepository _repository;

        public SalesService(IHttpContextAccessor httpContextAccessor, ISalesRepository repository)
        {
            _HttpContextAccessor = httpContextAccessor;
            _repository = repository;
        }
        public void Excluir(int id)
        {
            _repository.Delete(id);
        }

        public Task<IEnumerable<SalesEntity>> GetAll()
        {
            var result = _repository.GetAll();
            return result;
        }

        public void Insert(SalesEntity item)
        {
            _repository.Add(item);
        }

        public Task<SalesEntity> Update(SalesEntity item)
        {
            throw new NotImplementedException();
        }

        public Task<SalesEntity> Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
