using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using MyFinance.Service.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class ExtractServiceApplication : IExtractServiceApplication
    {
        private readonly IExtractService _service;

        public ExtractServiceApplication(IExtractService service)
        {
            _service = service;
        }
        public void Excluir(int id)
        {
            _service.Excluir(id);
        }

        public Task<IEnumerable<ExtractEntity>> GetAll()
        {
            return _service.GetAll();
        }
        public void Add(ExtractEntity item)
        {

            _service.Insert(item);
        }
        public void Insert(ExtractEntity item)
        {
            _service.Insert(item);
        }

        public Task<ExtractEntity> Update(ExtractEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public ExtractEntity Get(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
