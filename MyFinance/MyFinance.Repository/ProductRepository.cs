using Microsoft.EntityFrameworkCore;
using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IProductRepository _repository;

        SqlContext _context = new SqlContext();
        private DbSet<ProductEntity> _dataset;

        public ProductRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<ProductEntity>();
        }
        public Task<ProductEntity> Add(ProductEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<ProductEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ProductEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductEntity>> GetAll()
        {
            var result = _repository.GetAll();
            return result;
        }

        public IEnumerable<ProductEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<ProductEntity> Update(ProductEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
