using Microsoft.AspNetCore.Http;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using MyFinance.Service.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Service
{
    public class CustomerService : ICustomerService
    {
        public IHttpContextAccessor _HttpContextAccessor { get; set; }
        private readonly ICustomerRepository _repository;

        public CustomerService(IHttpContextAccessor httpContextAccessor, ICustomerRepository repository)
        {
            _HttpContextAccessor = httpContextAccessor;
            _repository = repository;
        }

        public void Excluir(int id)
        {
            _repository.Delete(id);
        }

        public Task<IEnumerable<CustomerEntity>> GetAll()
        {
            var result = _repository.GetAll();
            return result;
        }

        public void Insert(CustomerEntity item)
        {
            _repository.Add(item);
        }

        public Task<CustomerEntity> Update(CustomerEntity item)
        {
            throw new System.NotImplementedException();
        }

        public CustomerEntity Get(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
