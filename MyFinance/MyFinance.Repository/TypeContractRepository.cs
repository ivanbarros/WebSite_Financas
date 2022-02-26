using Microsoft.EntityFrameworkCore;
using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Repository
{
    public class TypeContractRepository : ITypeContractRepository
    {
        private readonly ITypeContractRepository _accountRepository;

        SqlContext _context = new SqlContext();
        private DbSet<TypeContractEntity> _dataset;

        public TypeContractRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<TypeContractEntity>();
        }
        public Task<TypeContractEntity> Add(TypeContractEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TypeContractEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TypeContractEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TypeContractEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TypeContractEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<TypeContractEntity> Update(TypeContractEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
