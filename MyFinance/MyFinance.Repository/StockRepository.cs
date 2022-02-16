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
    public class StockRepository : IStockRepository
    {   
        SqlContext _context = new SqlContext();
        private DbSet<StockEntity> _dataset;

        public StockRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<StockEntity>();
        }
        public Task<StockEntity> Add(StockEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<StockEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StockEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StockEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<StockEntity> Update(StockEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
