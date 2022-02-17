using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using System.Collections.Generic;

namespace MyFinance.Repository.Interfaces.Repositories
{
    public interface IAccountPlanRepository : IRepositoryBase<AccountPlanEntity, SqlContext>
    {
        List<AccountPlanEntity> ListaConta(int id);
    }
}
