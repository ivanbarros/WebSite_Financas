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
        [Required(ErrorMessage = "Informe a Categoria")]
        [Display(Name = "Categoria")]
        public CategoryEnum CategoryEnum { get; set; }


        [Column("Category")]
        [Display(Name = "Categoria")]
        public string Category { get; set; }


        [NotMapped]
        [Required(ErrorMessage = "Informe Despesa ou Receita")]
        [Display(Name = "Despsa/Receita")]
        public CashFlowTypeEnum TipoCashEnum { get; set; }

        [Column("IdUser")]
        public int Usuario_id { get; set; }

        [Column("IsActive")]
        public bool IsActive { get; set; }

        [Column("ValueCash")]
        [Display(Name = "Valor")]
        [Required(ErrorMessage = "Informe o valor")]
        [DisplayFormat(DataFormatString = "{0:0,0.000000}")]
        public decimal ValueCash { get; set; }

        [NotMapped]
        [Display(Name ="Valor Total de Despesas")]
        public decimal ValorTotalDespesa { get; set; }
        
        [NotMapped]
        [Display(Name ="Valor Total de Receita")]
        public decimal ValorTotalReceita { get; set; }

        [Column("IsPago")]
        [Required(ErrorMessage = "Informe Pagamento efetuado")]
        [Display(Name ="Efetuado Pagamento")]
        public bool IsPago { get; set; }

        [Column("PaymentDate")]
        [Required(ErrorMessage = "Informe a data de vencimento")]
        [Display(Name ="Data do vencimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime PaymentDate { get; set; }

        [Column("DatePaymentRealized")]
        [Required(ErrorMessage = "Informe Pagamento realizado")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name ="Pagamento realizado")]
        public DateTime DatePaymentRealized { get; set; }

        [Column("UpdatedDate")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Ultima atualização")]
        public DateTime UpdatedDate { get; set; }


        [NotMapped]
        public IsPagoEnum Pago { get; set; }
        [NotMapped]
        public IHttpContextAccessor HttpContextAccessor { get; set; }
    }
}
