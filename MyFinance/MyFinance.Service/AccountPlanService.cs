using Microsoft.AspNetCore.Http;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using MyFinance.Service.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Service
{
    public class AccountPlanService : IAccountPlanService
    {
        public IHttpContextAccessor _HttpContextAccessor { get; set; }
        private readonly IAccountPlanRepository _repository;

        public AccountPlanService(IHttpContextAccessor httpContextAccessor, IAccountPlanRepository repository)
        {
            _HttpContextAccessor = httpContextAccessor;
            _repository = repository;
        }

        public void Excluir(int id)
        {
            _repository.Delete(id);
        }

        public Task<IEnumerable<AccountPlanEntity>> GetAll()
        {
            var result = _repository.GetAll();
            return result;
        }

        public void Insert(AccountPlanEntity item)
        {
            _repository.Add(conta);
        }

        public List<AccountPlanEntity> ListaConta(int id)
        {
            var result = _repository.ListaConta(id);
            return result;
        }
    }
}
