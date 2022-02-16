using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using MyFinance.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class StockServiceApplication : IStockServiceApplication
    {
        private readonly StockService _service;

        public StockServiceApplication(StockService service)
        {
            _service = service;
        }

        public void Excluir(int id)
        {
            _service.Excluir(id);
        }

        public Task<IEnumerable<StockEntity>> GetAll()
        {
            var result = _service.GetAll();
            return result; ;
        }

        public void Insert(StockEntity item)
        {
            _service.Insert(item);
        }

        public Task<StockEntity> Update(StockEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
