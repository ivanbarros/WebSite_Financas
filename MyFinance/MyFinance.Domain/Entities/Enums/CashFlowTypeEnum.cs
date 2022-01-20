using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyFinance.Domain.Entities.Enums
{
    public enum CashFlowTypeEnum
    {
        [Display(Name="Receita")]
        receita,
        
        [Display(Name ="Despesa")]
        despesa
    }
}
