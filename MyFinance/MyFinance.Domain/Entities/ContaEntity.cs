using Microsoft.AspNetCore.Http;
using MyFinance.Domain.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyFinance.Domain.Entities
{
    public class ContaEntity : BaseEntity
    {
        [Required(ErrorMessage = "Informe o nome da conta")]
        [Display(Name = "Conta")]
        public string NomeConta { get; set; }

        [Required(ErrorMessage = "Informe o saldo")]
        [Display(Name = "Saldo")]
        public double Saldo { get; set; }

        [Display(Name = "Usuario")]
        public int Usuario_idUsuario { get; set; }

        public UserEntity Usuario { get; set; }

        //public IHttp Http { get; set; }
    }
}
