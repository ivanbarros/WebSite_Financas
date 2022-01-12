using MyFinance.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Service.Interfaces.Services
{
    public interface IContaService : IServiceBase<ContaEntity>
    {
       List<ContaEntity> ListaConta(int id);
    }
}
