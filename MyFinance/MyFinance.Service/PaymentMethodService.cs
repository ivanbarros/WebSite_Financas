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
    public class PaymentMethodService : IPaymentMethodService
    {
        private readonly IPaymentMethodRepository _paymentMethodRepository;
        public IHttpContextAccessor _HttpContextAccessor { get; set; }
        private readonly IPaymentMethodRepository _repository;

        public PaymentMethodService(IHttpContextAccessor httpContextAccessor, 
            IPaymentMethodRepository repository)
        {
            _HttpContextAccessor = httpContextAccessor;
            _repository = repository;
        }
        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PaymentMethodEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(PaymentMethodEntity item)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentMethodEntity> Update(PaymentMethodEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
