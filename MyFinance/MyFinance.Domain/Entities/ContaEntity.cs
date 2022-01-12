using Microsoft.AspNetCore.Http;
using MyFinance.Domain.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyFinance.Domain.Entities
{
    [Table("Account")]
    public class ContaEntity : BaseEntity
    {
       

        [Column("AccountName")]
        [Required(ErrorMessage = "Informe o nome da conta")]
        [Display(Name = "Conta")]
        public string NomeConta { get; set; }

        [Column("Balance")]
        [Required(ErrorMessage = "Informe o saldo")]
        [Display(Name = "Saldo")]
        public decimal Saldo { get; set; }

        [Column("IdUser")]
        [Display(Name = "Usuario")]
        public int Usuario_idUsuario { get; set; }
        
        [NotMapped]
        public IHttpContextAccessor HttpContextAccessor { get; set; }
    }
}
