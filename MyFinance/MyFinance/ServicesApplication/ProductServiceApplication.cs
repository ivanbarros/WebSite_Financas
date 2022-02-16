using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using MyFinance.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class ProductServiceApplication : IProductServiceApplication
    {
        private readonly ProductService _service;

        public ProductServiceApplication(ProductService service)
        {
            _service = service;
        }
        public void Excluir(int id)
        {
            _service.Excluir(id);
        }

        public Task<IEnumerable<ProductEntity>> GetAll()
        {
            var result = _service.GetAll();
            return result;
        }

        public void Insert(ProductEntity item)
        {
            _service.Insert(item);
        }

        public Task<ProductEntity> Update(ProductEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
