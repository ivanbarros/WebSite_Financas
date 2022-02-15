using Microsoft.AspNetCore.Http;
using MyFinance.Domain.Entities.BaseEntities;
using MyFinance.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinance.Domain.Entities
{
    [Table("Account")]
    public class AccountEntity : BaseEntity
    {


        [Column("AccountName")]
        [Required(ErrorMessage = "Informe o nome da conta")]
        [Display(Name = "Conta")]
        public string NomeConta { get; set; }

        [Column("Balance")]
        [Required(ErrorMessage = "Informe o saldo")]
        [Display(Name = "Saldo")]
        [DisplayFormat(DataFormatString = "{0:0,0.000000}")]
        public decimal Saldo { get; set; }

        [Column("AccountType")]
        [Required(ErrorMessage = "Informe o tipo de conta")]
        [Display(Name = "Tipo de Conta")]
        public string AccountType { get; set; }
      
        [NotMapped]
        [Display(Name = "Tipo de Conta")]
        public AccountTypeEnum TypeAccountEnum { get; set; }

        [Column("DescriptionAccount")]
        [Display(Name = "Descrição de conta")]
        public string DescriptionAccount { get; set; }

        [Column("IdUser")]
        [Display(Name = "Usuario")]
        public int Usuario_idUsuario { get; set; }

        [Column("IsActive")]
        public bool IsActive { get; set; }
        [NotMapped]
        public IHttpContextAccessor HttpContextAccessor { get; set; }
    }

}
