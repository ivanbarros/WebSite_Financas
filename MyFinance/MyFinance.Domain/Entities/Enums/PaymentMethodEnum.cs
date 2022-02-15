using System.ComponentModel.DataAnnotations;

namespace MyFinance.Domain.Entities.Enums
{
    public enum PaymentMethodEnum
    {
        [Display(Name = "Dinheiro")]
        cash,
        [Display(Name = "Debito")]
        debit,
        [Display(Name = "Crédito")]
        credit,
        [Display(Name = "Cheque")]
        check,
        [Display(Name = "Pix")]
        pix,
        [Display(Name = "Transferência")]
        transfer
    }
}
