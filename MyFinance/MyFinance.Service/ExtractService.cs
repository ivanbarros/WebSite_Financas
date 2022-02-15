using Microsoft.AspNetCore.Http;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using MyFinance.Service.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Service
{
    public class ExtractService : IExtractService
    {
        public IHttpContextAccessor _HttpContextAccessor { get; set; }
        private readonly IExtractRepository _repository;

        public ExtractService(IHttpContextAccessor httpContextAccessor, IExtractRepository repository)
        {
            _HttpContextAccessor = httpContextAccessor;
            _repository = repository;
        }
        public void Excluir(int id)
        {
            _repository.Delete(id);
        }

        public Task<IEnumerable<ExtractEntity>> GetAll()
        {
            var result = _repository.GetAll();
            return result;
        }

        public void Insert(ExtractEntity item)
        {
            throw new System.NotImplementedException();


        }

        public Task<ExtractEntity> Update(ExtractEntity item)
        {
            throw new System.NotImplementedException();
        }

        public ExtractEntity Get(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
