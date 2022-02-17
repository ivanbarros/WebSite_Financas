using Microsoft.AspNetCore.Http;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using MyFinance.Service.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Service
{
    public class DevolutionService : IDevolutionService
    {
        public IHttpContextAccessor _HttpContextAccessor { get; set; }
        private readonly IDevolutionRepository _repository;

        public DevolutionService(IHttpContextAccessor httpContextAccessor, IDevolutionRepository repository)
        {
            _HttpContextAccessor = httpContextAccessor;
            _repository = repository;
        }

        public Task<IEnumerable<DevolutionEntity>> GetAll()
        {
            var result = _repository.GetAll();
            return result;
        }

        public void Insert(DevolutionEntity item)
        {
            _repository.Add(item);
        }

        public void Excluir(int id)
        {
            _repository.Delete(id);
        }

        public Task<DevolutionEntity> Update(DevolutionEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
