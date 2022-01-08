using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Repository.Interfaces.Repositories
{
    public interface IUserRepository : IRepositoryBase<UserEntity,SqlContext>
    {

        UserEntity ValidarLogin(UserEntity usuario);
        
    }
}
