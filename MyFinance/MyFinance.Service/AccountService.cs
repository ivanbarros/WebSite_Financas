using Microsoft.AspNetCore.Http;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using MyFinance.Service.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Service
{

    public class AccountService : IAccountService
    {
        public IHttpContextAccessor _HttpContextAccessor { get; set; }
        private readonly IAccountRepository _repository;

        public AccountService(IHttpContextAccessor httpContextAccessor, IAccountRepository repository)
        {
            _HttpContextAccessor = httpContextAccessor;
            _repository = repository;
        }

        public void Excluir(int id)
        {
            _repository.Delete(id);
        }

        public Task<IEnumerable<AccountEntity>> GetAll()
        {

            var result = _repository.GetAll();
            return result;
        }

        public void Insert(AccountEntity conta)
        {
            
            
            _repository.Add(conta);
            
        }

        public List<AccountEntity> ListaConta(int id)
        {
            var result =  _repository.ListaConta(id);
            return result;
        }

        public Task<AccountEntity> Update(AccountEntity item)
        {
            throw new System.NotImplementedException();
        }

        public Task<AccountEntity> Get(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
