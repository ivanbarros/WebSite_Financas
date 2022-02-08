using Microsoft.EntityFrameworkCore;
using MyFinance.Data.Context;
using MyFinance.Repository.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Repository
{
    public class CategoryEnumRepository : ICategoryEnumRepository
    {
        SqlContext _context = new SqlContext();
        private DbSet<CategoryEnumEntity> _dataset;

        public CategoryEnumRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<CategoryEnumEntity>();
        }
        public System.Threading.Tasks.Task<CategoryEnumEntity> Add(CategoryEnumEntity entity)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<CategoryEnumEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<CategoryEnumEntity> Get(int id)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<IEnumerable<CategoryEnumEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryEnumEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<CategoryEnumEntity> Update(CategoryEnumEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
