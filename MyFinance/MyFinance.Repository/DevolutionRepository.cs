using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Repository
{
    public class DevolutionRepository : IDevolutionRepository
    {
        public Task<DevolutionEntity> Add(DevolutionEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<DevolutionEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DevolutionEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DevolutionEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DevolutionEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<DevolutionEntity> Update(DevolutionEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
