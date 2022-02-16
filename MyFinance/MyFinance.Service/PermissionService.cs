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
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionService _permissionService;

        public IHttpContextAccessor _HttpContextAccessor { get; set; }
        private readonly IPermissionRepository _repository;

        public PermissionService(IHttpContextAccessor httpContextAccessor, IPermissionRepository repository)
        {
            _HttpContextAccessor = httpContextAccessor;
            _repository = repository;
        }
        public void Excluir(int id)
        {
            _repository.Delete(id);
        }

        public Task<IEnumerable<PermissionEntity>> GetAll()
        {
            var result = _repository.GetAll();
            return result;
        }

        public void Insert(PermissionEntity item)
        {
            _repository.Add(item);
        }

        public Task<PermissionEntity> Update(PermissionEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
