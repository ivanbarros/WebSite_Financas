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
    public class EmployeeService : IEmployeeService
    {
        public IHttpContextAccessor _HttpContextAccessor { get; set; }
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IHttpContextAccessor httpContextAccessor, IEmployeeRepository repository)
        {
            _HttpContextAccessor = httpContextAccessor;
            _repository = repository;
        }
        public void Excluir(int id)
        {
            _repository.Delete(id);
        }

        public Task<IEnumerable<EmployeeEntity>> GetAll()
        {
            var result = _repository.GetAll();
            return result;
        }

        public void Insert(EmployeeEntity item)
        {
            _repository.Add(item);
        }

        public Task<EmployeeEntity> Update(EmployeeEntity item)
        {
            throw new NotImplementedException();
        }

        public EmployeeEntity Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
