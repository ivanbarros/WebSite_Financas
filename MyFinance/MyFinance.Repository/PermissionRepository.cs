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
    public class PermissionRepository : IPermissionRepository
    {
        private readonly IPermissionRepository _permissionRepository;

        SqlContext _context = new SqlContext();
        private DbSet<PermissionEntity> _dataset;

        public PermissionRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<PermissionEntity>();
        }
        public Task<PermissionEntity> Add(PermissionEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<PermissionEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PermissionEntity> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PermissionEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PermissionEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<PermissionEntity> Update(PermissionEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
