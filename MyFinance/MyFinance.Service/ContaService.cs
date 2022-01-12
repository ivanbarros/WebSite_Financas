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
        public IHttpContextAccessor _HttpContextAccessor { get; set; }
        private readonly IContaRepository _repository;

        public ContaService(IHttpContextAccessor httpContextAccessor, IContaRepository repository)
        {
            _HttpContextAccessor = httpContextAccessor;
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

        public List<ContaEntity> ListaConta(int id)
        {
            var result =  _repository.ListaConta(id);
            return result;
        }

      
    }
}
