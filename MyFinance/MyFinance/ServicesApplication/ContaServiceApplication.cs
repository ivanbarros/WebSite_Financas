using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using MyFinance.Service.Interfaces.Services;
using System.Collections.Generic;

namespace MyFinance.Application.ServicesApplication
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

        public List<ContaEntity> GetAll(ContaEntity item)
        {
           var result =  _service.GetAll(item);
            return result;
        }

        public void Insert(ContaEntity item)
        {
            _service.Insert(item);
        }
    }
}
