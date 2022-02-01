using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services.InterfaceBase;
using System.Collections.Generic;

namespace MyFinance.Interfaces.Services
{
    public interface ICashFlowServiceApplication : IServiceApplicationBase<CashFlowEntity>
    {
        public List<CashFlowEntity> ListaPlanoContas(int id);
        List<CashFlowEntity> GetDespesaReceita(int Id, string decision, string nameCategoria);
    }
}
