using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Repository.Interfaces.Repositories
{
    public interface IExtractRepository : IRepositoryBase<ExtractEntity, SqlContext>
    {
        public Task<ExtractEntity> Add(ExtractEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<ExtractEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ExtractEntity> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ExtractEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExtractEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<ExtractEntity> Update(ExtractEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
