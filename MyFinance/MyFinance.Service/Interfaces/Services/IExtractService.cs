using MyFinance.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Service.Interfaces.Services
{
    public interface IExtractService : IServiceBase<ExtractEntity>
    {
        Task<IEnumerable<ExtractEntity>> GetAll(object result);
    }
}
