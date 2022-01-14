using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using MyFinance.Service.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Service
{
    public class CashFlowService : ICashFlowService
    {
        private readonly ICashFlowRepository _repository;

        public CashFlowService(ICashFlowRepository repository)
        {
            _repository = repository;
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CashFlowEntity>> GetAll()
        {
            var result = _repository.GetAll();
            return result;
        }

        public void Add(CashFlowEntity item)
        {
            _repository.Add(item);
        }

        public List<CashFlowEntity> ListaPlanoContas(int id)
        {
            var result = _repository.ListaPlanoContas(id);
            return result;
        }

        public void Insert(CashFlowEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
