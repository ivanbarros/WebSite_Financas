using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Repository
{
    public class CashFlowTypeEnumRepository : ICashFlowTypeEnumRepository
    {
        public Task<CashFlowTypeEnumEntity> Add(CashFlowTypeEnumEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<CashFlowTypeEnumEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CashFlowTypeEnumEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CashFlowTypeEnumEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CashFlowTypeEnumEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<CashFlowTypeEnumEntity> Update(CashFlowTypeEnumEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
