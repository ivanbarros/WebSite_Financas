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
    public class ProductTypeService : IProductTypeService
    {
        public IHttpContextAccessor _HttpContextAccessor { get; set; }
        private readonly IProductTypeRepository _repository;

        public ProductTypeService(IHttpContextAccessor httpContextAccessor, IProductTypeRepository repository)
        {
            _HttpContextAccessor = httpContextAccessor;
            _repository = repository;
        }
        public void Excluir(int id)
        {
            _repository.Delete(id);
        }

        public Task<IEnumerable<ProductTypeEntity>> GetAll()
        {
            var result = _repository.GetAll();
            return result;
        }

        public void Insert(ProductTypeEntity item)
        {
            _repository.Add(item);
        }

        public Task<ProductTypeEntity> Update(ProductTypeEntity item)
        {
            throw new NotImplementedException();
        }

        public Task<ProductTypeEntity> Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
