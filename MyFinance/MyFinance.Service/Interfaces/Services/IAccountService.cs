using MyFinance.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Service.Interfaces.Services
{
    public interface IAccountService : IServiceBase<AccountEntity>
    {
       List<AccountEntity> ListaConta(int id);
    }
}
