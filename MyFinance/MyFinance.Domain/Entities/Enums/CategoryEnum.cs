using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyFinance.Domain.Entities.Enums
{
    public enum CategoryEnum
    {
        
        [Description("Mercado")]
        mercado,
        
        [Description("Lazer")]
        lazer,
        
        [Description("Contas Fixas")]
        contas,
        
        [Description("Vestuário")]
        vestuario,

        [Description("Saúde")]
        saude
    }
}
