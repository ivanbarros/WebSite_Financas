using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using MyFinance.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class ProductTypeServiceApplication : IProductTypeServiceApplication
    {
        private readonly ProductTypeService _service;

        public ProductTypeServiceApplication(ProductTypeService service)
        {
            _service = service;
        }
        public void Excluir(int id)
        {
            _service.Excluir(id);
        }

        public Task<IEnumerable<ProductTypeEntity>> GetAll()
        {
            var result = _service.GetAll();
            return result;
        }

        public void Insert(ProductTypeEntity item)
        {
            _service.Insert(item);
        }

        public Task<ProductTypeEntity> Update(ProductTypeEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
