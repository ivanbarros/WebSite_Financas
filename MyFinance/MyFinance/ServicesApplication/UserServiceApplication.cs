using MyFinance.Domain.Entities;
using MyFinance.Interfaces;
using MyFinance.Service.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class UserServiceApplication : IUserServiceApplication
    {
        private readonly IUserService _service;

        public UserServiceApplication(IUserService service)
        {
            _service = service;
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(UserEntity item)
        {
            _service.Insert(item);
        }
    }
}
