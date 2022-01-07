using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyFinance.Domain.Entities
{
    public class ContaEntity
    {
       // public IHttp _http { get; set; }
        public ContaEntity()
        {

        }
        public ContaEntity(int idConta, string nomeConta, double saldo, int usuario_idUsuario)
        {
            this.idConta = idConta;
            NomeConta = nomeConta;
            Saldo = saldo;
            Usuario_idUsuario = usuario_idUsuario;
        }

        //public ContaEntity(IHttp http)
        //{
        //    _http = http;
            
        //}

        [Key]
        [Display(Name = "ID")]
        public int idConta { get; set; }

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
