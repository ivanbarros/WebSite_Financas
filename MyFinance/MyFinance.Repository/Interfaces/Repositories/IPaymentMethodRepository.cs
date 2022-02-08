using MyFinance.Data.Context;
using MyFinance.Domain.Entities;

namespace MyFinance.Repository.Interfaces.Repositories
{
    partial interface IPaymentMethodRepository : IRepositoryBase<PaymentMethodEntity,SqlContext>
    {

    }
}
