using MyFinance.Data.Context;
using MyFinance.Domain.Entities;

namespace MyFinance.Repository.Interfaces.Repositories
{
    public interface IProductRepository : IRepositoryBase<ProductEntity,SqlContext>
    {

    }
}
