using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using MyFinance.Service.Interfaces.Services;
using System.Collections.Generic;

namespace MyFinance.Service
{

    public class ContaService : IContaService
    {
        private readonly IContaRepository _repository;

        public ContaService(IContaRepository repository)
        {
            _repository = repository;
        }

        public void Excluir(int id)
        {
            _repository.Excluir(id);
        }

        public List<ContaEntity> GetAll(ContaEntity conta)
        {

            var result = _repository.GetAll(conta);
            return result;
        }

        public void Insert(ContaEntity conta)
        {
            _repository.Insert(conta);
            
        }
    }
}
