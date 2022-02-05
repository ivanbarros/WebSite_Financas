using MyFinance.Domain.Entities;
using System.Collections.Generic;

namespace MyFinance.Service.Interfaces.Services
{
    public interface ICashFlowService : IServiceBase<CashFlowEntity>
    {
        
        public List<CashFlowEntity> GetDespesaReceita(int Id, string decision, string nameCategoria);
    }
}
