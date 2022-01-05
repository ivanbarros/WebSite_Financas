using MyFinance.Domain.Entities;
using System.Collections.Generic;

namespace MyFinance.Service.Interfaces.Services
{
    public interface IContaService : IServiceBase<ContaEntity>
    {
        List<ContaEntity> ListaConta(string login, string senha);
    }
}
