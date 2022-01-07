using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services.InterfaceBase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Interfaces.Services
{
    public interface IContaServiceApplication: IServiceApplicationBase<ContaEntity>
    {
        Task<IEnumerable<ContaEntity>> ListaConta();

    }
}
