using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Domain.Entities.BaseEntities;
using MyFinance.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinance.Domain.Entities
{
    public class CashFlowEntity : BaseEntity
    {
        [Column("Descricao")]
        [Required(ErrorMessage = "Informe a descrição")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Column("Tipo")]
        [BindProperty]
        [Required(ErrorMessage = "Informe o Tipo de conta")]
        [Display(Name = "Tipo de conta")]
        public string Tipo { get; set; }

        [NotMapped]
        public CashFlowTypeEnum TipoCashEnum { get; set; }

        public int Usuario_id { get; set; }

        [NotMapped]
        public IHttpContextAccessor HttpContextAccessor { get; set; }

        //public CashFlowEntity()
        //{

        //}

        //Recebe o context para acesso as variaveis de sessão
        //public CashFlowEntity(IHttpContextAccessor httpContextAccessor)
        //{
        //    HttpContextAccessor = httpContextAccessor;
        //}
        //private string idUsuarioLogado()
        //{
        //    return HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
        //}
    }
}
