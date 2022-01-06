using Microsoft.EntityFrameworkCore;
using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly IRepositoryBase<UserEntity> _repos;

        public UserRepository(IRepositoryBase<UserEntity> repos)
        {
            _repos = repos;
        }

        public Task<UserEntity> Add(UserEntity user)
        {
            try
            {
                var result =_repos.Add(user);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<UserEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserEntity>> GetAll()
        {
            try
            {
                return await _repos.GetAll();
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<UserEntity> Update(UserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
