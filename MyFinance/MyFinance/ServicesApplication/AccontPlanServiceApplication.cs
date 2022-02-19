using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using MyFinance.Service.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class AccountPlanServiceApplication : IAccountPlanServiceApplication
    {
        private readonly IAccountPlanService _service;
       
        public void Excluir(int id)
        {
            _service.Excluir(id);
        }

        public AccountPlanEntity Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<AccountPlanEntity>> GetAll()
        {
            var result = _service.GetAll();
            return result;
        }

        public void Insert(AccountPlanEntity item)
        {
            _service.Insert(item);
        }

        public Task<AccountPlanEntity> Update(AccountPlanEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
