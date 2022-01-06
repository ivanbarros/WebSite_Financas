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
        private readonly IUnitOfWork _unitOfWork;
        private readonly SqlContext _context;
        

        public async Task<UserEntity> Add(UserEntity user)
        {
            try
            {

                var result = await _context.Usuario.AddAsync(user);
                await _context.SaveChangesAsync();
               
                return user;
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

        public async Task<IEnumerable<UserEntity>> GetAll()
        {
            try
            {
                var user = new UserEntity();
                var result = await _context.Usuario.ToListAsync();
                return result;
                
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
