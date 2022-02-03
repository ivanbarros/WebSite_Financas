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
    public class AccountRepository : IAccountRepository
    {
        SqlContext _context = new SqlContext();
        private DbSet<AccountEntity> _dataset;

        public AccountRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<AccountEntity>();
        }

        public Task<AccountEntity> Add(AccountEntity entity)
        {
            
            try
            {
                entity.IsActive = true;
                entity.CreateDate = DateTime.UtcNow;
                
                _dataset.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Task.FromResult(entity);
        }

        public void Add(object extract)
        {
            throw new NotImplementedException();
        }

        public Task<AccountEntity> Delete(int id)

        {
            throw new NotImplementedException();
        }

        public Task<AccountEntity> Get(int id)

        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AccountEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AccountEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public List<AccountEntity> ListaConta(int id)
        {
            
            List<AccountEntity> conta = new List<AccountEntity>();
            var result =  _context.Conta.Where(c=>c.Usuario_idUsuario.Equals(id)).ToList();
            foreach (var item in result)
            {
                
                conta.Add(item);
            }
                return conta;
        }

        public Task<AccountEntity> Update(AccountEntity entity)
        {
            throw new NotImplementedException();
        }

    }
}
