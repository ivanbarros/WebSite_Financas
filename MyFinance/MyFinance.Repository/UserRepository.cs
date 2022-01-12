using Microsoft.EntityFrameworkCore;
using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using MyFinance.Domain.UnitOfWorkConfig.Interface;
using MyFinance.Repository.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinance.Repository
{
    public class UserRepository : IUserRepository
    {
        SqlContext _context = new SqlContext();
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

        public async Task<UserEntity> ValidarLogin(UserEntity usuario)
        {
            try
            {

                //var users = _context.Usuario.Select(p => new { p.UserName, p.PassWord , p.Login,p.CreateDate,p.Email,p.Id, p.IsActive});
                var users = _context.Usuario.Where(c => c.UserName.Equals(usuario.UserName) && c.PassWord.Equals(usuario.PassWord)).AsAsyncEnumerable();
                await foreach (var item in users)
                {
                    usuario.UserName = item.UserName;
                    usuario.Id = item.Id;
                    usuario.IsActive = item.IsActive;
                    usuario.Login = item.Login;
                    usuario.Email = item.Email;
                    usuario.PassWord = item.PassWord;
                }

                //var users = _context.Usuario.Where(c => c.UserName.Equals(usuario.UserName) && c.PassWord.Equals(usuario.PassWord)).AsAsyncEnumerable();


                //foreach (var item in users.ToString())
                //{


                //}
                

                return usuario;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }


}
