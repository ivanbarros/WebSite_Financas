using Microsoft.AspNetCore.Http;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using MyFinance.Service.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Service
{

    public class ContaService : IContaService
    {
        //public IHttp Http { get; set; }
        private readonly IContaRepository _repository;

        public ContaService(IContaRepository repository)
        {
            
            _repository = repository;
        }

        public void Excluir(int id)
        {
            _repository.Delete(id);
        }

        public Task<IEnumerable<ContaEntity>> GetAll()
        {

            var result = _repository.GetAll();
            return result;
        }

        public void Insert(ContaEntity conta)
        {
            _repository.Add(conta);
            
        }

        public async Task<IEnumerable<ContaEntity>> ListaConta(string login, string senha)
        {
            var result = await _repository.ListaConta(login, senha);
            return result;
        }

      
    }
}
