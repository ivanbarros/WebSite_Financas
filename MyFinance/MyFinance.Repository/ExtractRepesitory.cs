using Microsoft.EntityFrameworkCore;
using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Repository
{
    public class ExtractRepesitory :IExtractRepository
    {
        SqlContext _context = new SqlContext();
        private DbSet<ExtractEntity> _dataset;

        public ExtractRepesitory(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<ExtractEntity>();
        }

        public Task<ExtractEntity> Add(ExtractEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ExtractEntity> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ExtractEntity> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ExtractEntity>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ExtractEntity> GetByEmail(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<ExtractEntity> Update(ExtractEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
