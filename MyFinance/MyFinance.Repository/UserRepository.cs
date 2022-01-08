using Microsoft.EntityFrameworkCore;
using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using MyFinance.Domain.UnitOfWorkConfig.Interface;
using MyFinance.Repository.Interfaces.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyFinance.Repository
{
    public class UserRepository : IUserRepository
    {
        SqlContext _context = new SqlContext();
        private DbSet<UserEntity> _dataset;
        private readonly IUnitOfWork _unitOfWork;
        public UserRepository(SqlContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _dataset = context.Set<UserEntity>();
            _unitOfWork = unitOfWork;
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
            return Task.FromResult(entity);
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

        public IEnumerable<UserEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> Update(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public UserEntity ValidarLogin(UserEntity usuario)
        {
            try
            {
                var users = _dataset.SingleOrDefault(c=>c.UserName.Equals(usuario.UserName));
                //UserEntity listUser = new UserEntity();
                usuario.Login = users.Login;

                return usuario;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }


}
