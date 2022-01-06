using MyFinance.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Service.Interfaces.Services
{
    public interface IContaService : IServiceBase<ContaEntity>
    {
       Task< IEnumerable<ContaEntity>> ListaConta(string login, string senha);
    }
}
