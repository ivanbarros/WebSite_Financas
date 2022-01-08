using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Service.Interfaces.Services
{
    public interface IUserService : IServiceBase<UserEntity>
    {

        UserEntity ValidarLogin(UserEntity usuario);

    }
}
