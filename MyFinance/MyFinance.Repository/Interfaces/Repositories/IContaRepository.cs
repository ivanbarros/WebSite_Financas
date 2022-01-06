using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Repository.Interfaces.Repositories
{
    public interface IContaRepository : IRepositoryBase<ContaEntity>
    {
        Task<List<ContaEntity>> ListaConta(string login, string senha);
    }
}
