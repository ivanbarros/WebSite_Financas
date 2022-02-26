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
    public class CustomerRepository : ICustomerRepository
    {
        SqlContext _context = new SqlContext();
        private DbSet<CustomerEntity> _dataset;

        public CustomerRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<CustomerEntity>();
        }
        public Task<CustomerEntity> Add(CustomerEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CustomerEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CustomerEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerEntity> Update(CustomerEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
