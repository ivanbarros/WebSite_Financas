using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services.InterfaceBase;
using MyFinance.Service.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class AddressServiceApplication : IAddressServiceApplication
    {
        private readonly IAddressService _service;

        public AddressServiceApplication(IAddressService service)
        {
            _service = service;
        }

        public void Excluir(int id)
        {
            _service.Excluir(id);
        }

        public AddressEntity Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<AddressEntity>> GetAll()
        {
            var result = _service.GetAll();
            return result;
        }

        public void Insert(AddressEntity item)
        {
            _service.Insert(item);
        }

        public Task<AddressEntity> Update(AddressEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
