using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using MyFinance.Service.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

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
            throw new NotImplementedException();
        }

        public List<UserEntity> GetAll(UserEntity item)
        {
            throw new NotImplementedException();
        }

        public void Insert(UserEntity item)
        {
            _repository.Insert(item);
        }
    }
}
