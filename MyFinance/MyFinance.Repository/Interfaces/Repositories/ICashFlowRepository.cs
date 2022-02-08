using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using System.Collections.Generic;

namespace MyFinance.Repository.Interfaces.Repositories
{
    public interface ICashFlowRepository : IRepositoryBase<CashFlowEntity,SqlContext>
    {
        decimal ValorTotalDespesa(int userId, string categoria, string decision);
        CashFlowEntity Get(int id);
        List<CashFlowEntity> GetDespesaReceita(int Id, string decision, string nameCategoria);
        decimal ValorReceita(int userId, string nameCategoria, string decision);
    }
}
