using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyFinance.Domain.Entities.Enums
{
    public enum CategoryEnum
    {
        [Display(Name = "Mercado")]
        [Description("Mercado")]
        market,
        [Description("Lazer")]
        leisure,
        [Description("Contas Fixas")]
        bills,
        [Description("Vestuário")]
        clothing
    }
}
