using Microsoft.AspNetCore.Http;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using MyFinance.Service.Interfaces.Services;
using System.Collections.Generic;

namespace MyFinance.Service
{

    public class ContaService : IContaService
    {
        public IHttpContextAccessor HttpContextAccessor { get; set; }
        private readonly IContaRepository _repository;

        public ContaService(IHttpContextAccessor httpContextAccessor, IContaRepository repository)
        {
            HttpContextAccessor = httpContextAccessor;
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

        public List<ContaEntity> ListaConta(string login, string senha)
        {
            var result = _repository.ListaConta(login, senha);
            return result;
        }

      
    }
}
