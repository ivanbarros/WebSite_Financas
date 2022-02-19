using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using MyFinance.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class DevolutionServiceApplication : IDevolutionServiceApplication
    {
        private readonly DevolutionService _service;

        public DevolutionServiceApplication(DevolutionService service)
        {
            _service = service;
        }
        public void Excluir(int id)
        {
            _service.Excluir(id);
        }

        public DevolutionEntity Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<DevolutionEntity>> GetAll()
        {
            var result = _service.GetAll();
            return result;
        }

        public void Insert(DevolutionEntity item)
        {
            _service.Insert(item);
        }

        public Task<DevolutionEntity> Update(DevolutionEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
