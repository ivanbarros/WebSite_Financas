using System;
using System.ComponentModel.DataAnnotations;

namespace MyFinance.Domain.Entities.BaseEntities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Data do cadastro")]
        public DateTime CreateDate { get; set; }
    }
}
