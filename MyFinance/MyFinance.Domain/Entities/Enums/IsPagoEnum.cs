using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyFinance.Domain.Entities.Enums
{
    public enum IsPagoEnum
    {
        [Display(Name = "Sim")]
        Sim,
        
        [Display(Name = "Não")]
        Nao
    }
}
