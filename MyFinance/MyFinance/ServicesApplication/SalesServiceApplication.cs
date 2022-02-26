using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using MyFinance.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class SalesServiceApplication : ISalesServiceApplication
    {
        private readonly SalesService _service;

        public SalesServiceApplication(SalesService service)
        {
            _service = service;
        }
        public void Excluir(int id)
        {
            _service.Excluir(id);
        }

        public SalesEntity Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<SalesEntity>> GetAll()
        {
            var result = _service.GetAll();
            return result;
        }

        public void Insert(SalesEntity item)
        {
            _service.Insert(item);
        }

        public Task<SalesEntity> Update(SalesEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
