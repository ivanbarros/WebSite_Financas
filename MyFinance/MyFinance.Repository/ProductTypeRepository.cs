using Microsoft.EntityFrameworkCore;
using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Repository
{
    public class ProductTypeRepository : IProductTypeRepository
    {
        private readonly IProductTypeRepository _repository;

        SqlContext _context = new SqlContext();
        private DbSet<ProductTypeEntity> _dataset;

        public ProductTypeRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<ProductTypeEntity>();
        }

        public Task<ProductTypeEntity> Add(ProductTypeEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<ProductTypeEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ProductTypeEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductTypeEntity>> GetAll()
        {
            var result = _repository.GetAll();
            return result;
        }

        public IEnumerable<ProductTypeEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<ProductTypeEntity> Update(ProductTypeEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
