using Microsoft.AspNetCore.Http;
using MyFinance.Domain.Entities.BaseEntities;
using MyFinance.Domain.Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinance.Domain.Entities
{
    public class CashFlowEntity : BaseEntity
    {
        [Column("Description")]
        [Required(ErrorMessage = "Informe a descrição")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Column("TypeCashFlow")]
        [Required(ErrorMessage = "Informe o Tipo de conta")]
        [Display(Name = "Tipo de conta")]
        public string Tipo { get; set; }


        [NotMapped]
        [Display(Name = "Categoria")]
        public CategoryEnum CategoryEnum { get; set; }


        [Column("Category")]
        [Display(Name = "Categoria")]
        public string Category { get; set; }


        [NotMapped]
        [Display(Name = "Despsa/Receita")]
        public CashFlowTypeEnum TipoCashEnum { get; set; }

        [Column("IdUser")]
        public int Usuario_id { get; set; }

        [Column("IsActive")]
        public bool IsActive { get; set; }

        [Column("ValueCash")]
        [Display(Name = "Valor")]
        public decimal ValueCash { get; set; }

        [NotMapped]
        [Display(Name ="Valor Total de Despesas")]
        public decimal ValorTotalDespesa { get; set; }
        
        [NotMapped]
        [Display(Name ="Valor Total de Receita")]
        public decimal ValorTotalReceita { get; set; }

        [Column("IsPago")]
        [Display(Name ="Efetuado Pagamento")]
        public bool IsPago { get; set; }

        [Display(Name ="Data do pagamento")]
        [Column("PaymentDate")]
        public DateTime PaymentDate { get; set; }

        [Display(Name ="Pagamento realizado")]
        [Column("DatePaymentRealized")]
        public DateTime DatePaymentRealized { get; set; }

        [NotMapped]
        public IsPagoEnum Pago { get; set; }
        [NotMapped]
        public IHttpContextAccessor HttpContextAccessor { get; set; }
    }
}
