using MyFinance.Domain.Entities;
using System.Collections.Generic;

namespace MyFinance.Service.Interfaces.Services
{
    public interface ICashFlowService : IServiceBase<CashFlowEntity>
    {
        CashFlowEntity Get(int id);
        decimal ValorTotalDespesa(int userId, string nameCategoria ,string decision);
        public List<CashFlowEntity> GetDespesaReceita(int Id, string decision, string nameCategoria);
        decimal ValorTotalReceita(int userId, string categoria, string decision);
    }
}
