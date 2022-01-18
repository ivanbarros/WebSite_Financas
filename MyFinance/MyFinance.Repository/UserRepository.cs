using Microsoft.EntityFrameworkCore;
using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
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
                var permissionUser = _context.Permissions.Where(p =>p.Name.Equals(entity.TipoPermissao));
                foreach (var item in permissionUser)
                {
                    if (entity.TipoPermissao == item.Name)
                    {
                        entity.IdPermission = item.Id;

                    }
                }
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
                var users = _context.Usuario.Where(c => c.UserName.Equals(usuario.UserName) && c.PassWord.Equals(usuario.PassWord)).AsAsyncEnumerable();
                await foreach (var item in users)
                {
                    usuario.UserName = item.UserName;
                    usuario.IdPermission = item.IdPermission;
                    usuario.IsActive = item.IsActive;
                    usuario.Login = item.Login;
                    usuario.Email = item.Email;
                    usuario.PassWord = item.PassWord;
                    usuario.TipoPermissao = item.TipoPermissao;
                    usuario.IdPermission = item.IdPermission;
                    usuario.CreateDate = item.CreateDate;
                }
                return usuario;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }


}
