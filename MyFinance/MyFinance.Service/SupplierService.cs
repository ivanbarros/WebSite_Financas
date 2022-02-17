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
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierService _supplierService;
        public IHttpContextAccessor _HttpContextAccessor { get; set; }
        private readonly ISupplierRepository _repository;

        public SupplierService(IHttpContextAccessor httpContextAccessor, ISupplierRepository repository)
        {
            _HttpContextAccessor = httpContextAccessor;
            _repository = repository;
        }
        public void Excluir(int id)
        {
            _repository.Delete(id);
        }

        public Task<IEnumerable<SupplierEntity>> GetAll()
        {
            var result = _repository.GetAll();
            return result;
        }

        public void Insert(SupplierEntity item)
        {
            _repository.Add(item);
        }

        public Task<SupplierEntity> Update(SupplierEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
