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
    public class AddressService : IAddressService
    {
        public IHttpContextAccessor _HttpContextAccessor { get; set; }
        private readonly IAddressRepository _repository;

        public AddressService(IHttpContextAccessor httpContextAccessor, IAddressRepository repository)
        {
            _HttpContextAccessor = httpContextAccessor;
            _repository = repository;
        }
        public void Excluir(int id)
        {
            _repository.Delete(id);
        }

        public Task<IEnumerable<AddressEntity>> GetAll()
        {
            var result = _repository.GetAll();
            return result;
        }

        public void Insert(AddressEntity item)
        {
            _repository.Add(item);
        }

        public Task<AddressEntity> Update(AddressEntity item)
        {
            throw new NotImplementedException();
        }

        public AddressEntity Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
