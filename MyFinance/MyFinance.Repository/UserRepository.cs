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
        protected readonly SqlContext _context;
        private DbSet<UserEntity> _dataset;

        public UserRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<UserEntity>();
        }

        public Task<UserEntity> Add(UserEntity entity)
        {
            try
            {
                _dataset.Add(entity);
                 _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Task.FromResult(entity) ;
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
