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
    public class ProductService : IProductService
    {
        private readonly IProductService _productService;
        public IHttpContextAccessor _HttpContextAccessor { get; set; }
        private readonly IProductRepository _repository;

        public ProductService(IHttpContextAccessor httpContextAccessor, IProductRepository repository)
        {
            _HttpContextAccessor = httpContextAccessor;
            _repository = repository;
        }
        public void Excluir(int id)
        {
            _repository.Delete(id);
        }

        public Task<IEnumerable<ProductEntity>> GetAll()
        {
            var result = _repository.GetAll();
            return result;
        }

        public void Insert(ProductEntity item)
        {
            _repository.Add(item);
        }

        public Task<ProductEntity> Update(ProductEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
