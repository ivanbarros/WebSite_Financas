using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services.InterfaceBase;
using System.Collections.Generic;

namespace MyFinance.Interfaces.Services
{
    public interface ICashFlowServiceApplication : IServiceApplicationBase<CashFlowEntity>
    {

        
        List<CashFlowEntity> GetDespesaReceita(int Id, string decision, string nameCategoria);
        decimal ValorTotalDespesa(int userId, string categoria, string decision);
        decimal ValorTotalReceita(int userId, string categoryName, string decision);
    }
}
