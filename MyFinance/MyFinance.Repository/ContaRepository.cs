using Microsoft.AspNetCore.Http;
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
        private readonly SqlContext _context;

        public ContaRepository(SqlContext context)
        {
            _context = context;
        }

        public Task<ContaEntity> Add(ContaEntity entity)
        {
            throw new NotImplementedException();
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

        public Task<List<ContaEntity>> ListaConta(string login, string senha)
        {
            throw new NotImplementedException();
        }

        public Task<ContaEntity> Update(ContaEntity entity)
        {
            throw new NotImplementedException();
        }

    }
}
