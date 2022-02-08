using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
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

        public Task<UserEntity> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(UserEntity item)
        {
            _service.Insert(item);
        }

        public Task<UserEntity> Update(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public UserEntity ValidarLogin(UserEntity usuario)
        {
            var result = _service.ValidarLogin(usuario);
            
            return result;
        }
    }
}
