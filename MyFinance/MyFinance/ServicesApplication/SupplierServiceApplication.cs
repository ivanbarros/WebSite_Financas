using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using MyFinance.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class SupplierServiceApplication : ISupplierServiceApplication
    {
        private readonly SupplierService _service;

        public SupplierServiceApplication(SupplierService service)
        {
            _service = service;
        }
        public void Excluir(int id)
        {
            _service.Excluir(id);
        }

        public Task<SupplierEntity> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<SupplierEntity>> GetAll()
        {
            var result = _service.GetAll();
            return result;
        }

        public void Insert(SupplierEntity item)
        {
            _service.Insert(item);
        }

        public Task<SupplierEntity> Update(SupplierEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
