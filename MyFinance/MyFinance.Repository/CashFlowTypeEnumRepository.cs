using Microsoft.EntityFrameworkCore;
using MyFinance.Data.Context;
using MyFinance.Repository.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Repository
{
    public class CashFlowTypeEnumRepository : ICashFlowTypeEnumRepository
    {
        SqlContext _context = new SqlContext();
        private DbSet<CashFlowTypeEnumEntity> _dataset;

        public CashFlowTypeEnumRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<CashFlowTypeEnumEntity>();
        }
        public System.Threading.Tasks.Task<CashFlowTypeEnum> Add(CashFlowTypeEnum entity)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<CashFlowTypeEnum> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<CashFlowTypeEnum> Get(int id)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<IEnumerable<CashFlowTypeEnum>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CashFlowTypeEnum> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<CashFlowTypeEnum> Update(CashFlowTypeEnum entity)
        {
            throw new NotImplementedException();
        }
    }
}
