using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using MyFinance.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class PaymentMethodServiceApplication : IPaymentMethodServiceApplication
    {
        private readonly PaymentMethodService _service;

        public PaymentMethodServiceApplication(PaymentMethodService service)
        {
            _service = service;
        }
        public void Excluir(int id)
        {
            _service.Excluir(id);
        }

        public PaymentMethodEntity Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<PaymentMethodEntity>> GetAll()
        {
            var result = _service.GetAll();
            return result;
        }

        public void Insert(PaymentMethodEntity item)
        {
            _service.Insert(item);
        }

        public Task<PaymentMethodEntity> Update(PaymentMethodEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
