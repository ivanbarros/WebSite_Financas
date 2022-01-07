using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinance.Interfaces
{
    public interface IUserServiceApplication : IServiceApplicationBase <UserEntity>
    {

        UserEntity ValidarLogin(UserEntity usuario);
    }
}
