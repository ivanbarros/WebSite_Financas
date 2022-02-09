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
        saude,

        [Display(Name = "salário")]
        salario,

        [Display(Name = "poupança")]
        poupança,

        [Display(Name ="Recebimento por boleto")]
        recebimento_Boleto,

        [Display(Name = "Pix")]
        pix,

        [Display(Name = "Depósito Bancário")]
        deposito,

        [Display(Name = "Transferência Bancária")]
        transferencia

    }
}
