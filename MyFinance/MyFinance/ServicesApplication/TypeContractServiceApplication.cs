using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using MyFinance.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class TypeContractServiceApplication : ITypeContractServiceApplication
    {
        private readonly TypeContractService _service;

        public TypeContractServiceApplication(TypeContractService service)
        {
            _service = service;
        }

        public void Excluir(int id)
        {
            _service.Excluir(id);
        }

        public Task<IEnumerable<TypeContractEntity>> GetAll()
        {
            var result = _service.GetAll();
            return result;
        }

        public void Insert(TypeContractEntity item)
        {
            _service.Insert(item);
        }

        public Task<TypeContractEntity> Update(TypeContractEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
