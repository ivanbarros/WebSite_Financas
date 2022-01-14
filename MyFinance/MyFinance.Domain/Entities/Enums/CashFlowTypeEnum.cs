using System.ComponentModel;

namespace MyFinance.Domain.Entities.Enums
{
    public enum CashFlowTypeEnum
    {
        [Description("Receita")]
        receita,
        
        [Description("Despesa")]
        despesa
    }
}
