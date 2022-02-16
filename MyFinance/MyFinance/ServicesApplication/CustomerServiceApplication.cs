using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using MyFinance.Service.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class CustomerServiceApplication : ICustomerServiceApplication
    {
        private readonly ICustomerService _service;

        public CustomerServiceApplication(ICustomerService service)
        {
            _service = service;
        }
        public void Excluir(int id)
        {
            _service.Excluir(id);
        }

        public Task<IEnumerable<CustomerEntity>> GetAll()
        {
            var result = _service.GetAll();
            return result;
        }

        public void Insert(CustomerEntity item)
        {
            _service.Insert(item);
        }

        public Task<CustomerEntity> Update(CustomerEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
