using Microsoft.EntityFrameworkCore;
using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Repository
{
    public class PaymentMethodRepository : IPaymentMethodRepository
    {
        SqlContext _context = new SqlContext();
        private DbSet<PaymentMethodEntity> _dataset;

        public PaymentMethodRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<PaymentMethodEntity>();
        }
        public Task<PaymentMethodEntity> Add(PaymentMethodEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentMethodEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentMethodEntity> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PaymentMethodEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PaymentMethodEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentMethodEntity> Update(PaymentMethodEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
