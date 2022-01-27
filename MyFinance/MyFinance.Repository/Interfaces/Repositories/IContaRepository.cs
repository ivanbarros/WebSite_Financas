using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using System.Collections.Generic;

namespace MyFinance.Repository.Interfaces.Repositories
{
    public interface IContaRepository : IRepositoryBase<AccountEntity,SqlContext>
    {
        List<AccountEntity> ListaConta(int id);
        void Add(object extract);
    }
}
