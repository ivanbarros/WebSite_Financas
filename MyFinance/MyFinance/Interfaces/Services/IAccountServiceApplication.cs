using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services.InterfaceBase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Interfaces.Services
{
    public interface IAccountServiceApplication: IServiceApplicationBase<AccountEntity>
    {
        List<AccountEntity> ListaConta(int id);

    }
}
