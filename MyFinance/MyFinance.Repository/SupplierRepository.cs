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
    public class SupplierRepository : ISupplierRepository
    {
        private readonly ISupplierRepository _supplierRepository;

        SqlContext _context = new SqlContext();
        private DbSet<SupplierEntity> _dataset;

        public SupplierRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<SupplierEntity>();
        }
        public Task<SupplierEntity> Add(SupplierEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<SupplierEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public SupplierEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SupplierEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SupplierEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<SupplierEntity> Update(SupplierEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
