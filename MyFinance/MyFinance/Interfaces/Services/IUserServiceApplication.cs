﻿using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services.InterfaceBase;

namespace MyFinance.Interfaces.Services
{
    public interface IUserServiceApplication : IServiceApplicationBase <UserEntity>
    {

        UserEntity ValidarLogin(UserEntity usuario);
    }
}