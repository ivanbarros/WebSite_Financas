using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using MyFinance.Service.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public void Excluir(int id)
        {
            _repository.Delete(id);
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
            item.CreateDate = DateTime.UtcNow;
            item.IsActive = true;
            item.Login = item.Email;
            _repository.Add(item);
        }

        public Task<UserEntity> Update(UserEntity item)
        {
            throw new NotImplementedException();
        }

        public UserEntity ValidarLogin(UserEntity usuario)
        {
           var result =  _repository.ValidarLogin(usuario);
            
            return result.Result;
        }
    }
}
