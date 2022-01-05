using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Repository.Interfaces.Repositories
{
    public interface IContaRepository : IRepositoryBase<ContaEntity>
    {
        List<ContaEntity> ListaConta(string login, string senha);
    }
}
