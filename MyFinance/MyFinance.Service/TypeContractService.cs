using Microsoft.AspNetCore.Http;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using MyFinance.Service.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Service
{
    public class TypeContractService : ITypeContractService
    {
        public IHttpContextAccessor _HttpContextAccessor { get; set; }
        private readonly ITypeContractRepository _repository;

        public TypeContractService(IHttpContextAccessor httpContextAccessor, ITypeContractRepository repository)
        {
            _HttpContextAccessor = httpContextAccessor;
            _repository = repository;
        }
        public void Excluir(int id)
        {
            _repository.Delete(id);
        }

        public Task<IEnumerable<TypeContractEntity>> GetAll()
        {
            var result = _repository.GetAll();
            return result;
        }

        public void Insert(TypeContractEntity item)
        {
            _repository.Add(item);
        }

        public Task<TypeContractEntity> Update(TypeContractEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
