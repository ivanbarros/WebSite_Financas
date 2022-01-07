using Microsoft.EntityFrameworkCore;
using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using MyFinance.Domain.UnitOfWorkConfig.Interface;
using MyFinance.Repository.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Repository
{
    public class UserRepository : IUserRepository
    {
        protected readonly SqlContext _context;
        private DbSet<UserEntity> _dataset;

        public UserRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<UserEntity>();
        }

        public async Task<UserEntity> Add(UserEntity entity)
        {
            try
            {
                _dataset.Add(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return entity;
        }

        public Task<UserEntity> Delete(int id)
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

        public Task<UserEntity> Update(UserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
