using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using MyFinance.Service.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class CashFlowServiceApplication : ICashFlowServiceApplication
    {
        private readonly ICashFlowService _service;

        public CashFlowServiceApplication(ICashFlowService service)
        {
            _service = service;
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CashFlowEntity>> GetAll()
        {
            return _service.GetAll();
        }

        public void Add(CashFlowEntity item)
        {
            throw new NotImplementedException();
            //_service.Add(item);
        }

        public List<CashFlowEntity> ListaPlanoContas(int id)
        {
            var result = _service.ListaPlanoContas(id);
            return result;
        }

        public void Insert(CashFlowEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
