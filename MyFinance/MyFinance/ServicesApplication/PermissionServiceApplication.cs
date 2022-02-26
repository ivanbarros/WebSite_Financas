using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using MyFinance.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class PermissionServiceApplication : IPermissionServiceApplication
    {
        private readonly PermissionService _service;

        public PermissionServiceApplication(PermissionService service)
        {
            _service = service;
        }
        public void Excluir(int id)
        {
            _service.Excluir(id);
        }

        public PermissionEntity Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<PermissionEntity>> GetAll()
        {
            var result = _service.GetAll();
            return result;
        }

        public void Insert(PermissionEntity item)
        {
            _service.Insert(item);
        }

        public Task<PermissionEntity> Update(PermissionEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}