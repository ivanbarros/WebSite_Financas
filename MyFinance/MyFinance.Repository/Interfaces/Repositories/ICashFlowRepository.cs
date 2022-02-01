using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using System.Collections.Generic;

namespace MyFinance.Repository.Interfaces.Repositories
{
    public interface ICashFlowRepository : IRepositoryBase<CashFlowEntity,SqlContext>
    {
        List<CashFlowEntity> ListaPlanoContas(int id);
        List<CashFlowEntity> GetDespesaReceita(int Id, string decision, string nameCategoria);
    }
}
