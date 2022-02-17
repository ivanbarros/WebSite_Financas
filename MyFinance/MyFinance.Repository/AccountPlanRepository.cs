using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Repository
{
    public class AccountPlanRepository : IAccountPlanRepository
    {
        public Task<AccountPlanEntity> Add(AccountPlanEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<AccountPlanEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public AccountPlanEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AccountPlanEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AccountPlanEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public List<AccountPlanEntity> ListaConta(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AccountPlanEntity> Update(AccountPlanEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
