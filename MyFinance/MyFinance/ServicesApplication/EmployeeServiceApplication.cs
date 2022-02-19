using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using MyFinance.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class EmployeeServiceApplication : IEmployeeServiceApplication
    {
        private readonly EmployeeService _service;

        public EmployeeServiceApplication(EmployeeService service)
        {
            _service = service;
        }

        public void Excluir(int id)
        {
            _service.Excluir(id);
        }

        public EmployeeEntity Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<EmployeeEntity>> GetAll()
        {
            var result = _service.GetAll();
            return result;
        }

        public void Insert(EmployeeEntity item)
        {
            _service.Insert(item);
        }

        public Task<EmployeeEntity> Update(EmployeeEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
