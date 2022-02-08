using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using MyFinance.Service.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class AccountServiceApplication : IAccountServiceApplication
    {
        private readonly IAccountService _service;

        public AccountServiceApplication(IAccountService service)
        {
            _service = service;
        }

        public void Excluir(int id)
        {
            _service.Excluir(id);
        }

        public Task<AccountEntity> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<AccountEntity>> GetAll()
        {
           var result =  _service.GetAll();
            return result;
        }

        public void Insert(AccountEntity item)
        {
            _service.Insert(item);
        }

        public List<AccountEntity> ListaConta(int Id)
        {
           var result =  _service.ListaConta(Id);
            return result;
        }

        public Task<AccountEntity> Update(AccountEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
