using Microsoft.AspNetCore.Http;
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
    public class ContaRepository : IContaRepository
    {
        SqlContext _context = new SqlContext();
        private DbSet<ContaEntity> _dataset;

        public ContaRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<ContaEntity>();
        }

        public Task<ContaEntity> Add(ContaEntity entity)
        {
            
            try
            {
                //Convert.ToDouble(entity.Saldo);
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

        public Task<ContaEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ContaEntity> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ContaEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ContaEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public List<ContaEntity> ListaConta(int id)
        {
            
            List<ContaEntity> conta = new List<ContaEntity>();
            var result =  _context.Conta.Where(c=>c.Usuario_idUsuario.Equals(id)).ToList();
            foreach (var item in result)
            {
                conta.Add(item);
            }
                return conta;
        }

        public Task<ContaEntity> Update(ContaEntity entity)
        {
            throw new NotImplementedException();
        }

    }
}
