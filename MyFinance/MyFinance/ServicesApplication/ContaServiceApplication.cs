using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using MyFinance.Service.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class ContaServiceApplication : IContaServiceApplication
    {
        private readonly IContaService _service;

        public ContaServiceApplication(IContaService service)
        {
            _service = service;
        }

        public void Excluir(int id)
        {
            _service.Excluir(id);
        }

        public Task<IEnumerable<ContaEntity>> GetAll()
        {
           var result =  _service.GetAll();
            return result;
        }

        public void Insert(ContaEntity item)
        {
            _service.Insert(item);
        }

        public Task<IEnumerable<ContaEntity>> ListaConta()
        {
            throw new System.NotImplementedException();
        }
    }
}
