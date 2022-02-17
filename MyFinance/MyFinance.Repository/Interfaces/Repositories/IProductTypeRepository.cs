using MyFinance.Data.Context;
using MyFinance.Domain.Entities;

namespace MyFinance.Repository.Interfaces.Repositories
{
    public interface IProductTypeRepository : IRepositoryBase<ProductTypeEntity,SqlContext>
    {

    }
}
