using System;
using System.ComponentModel.DataAnnotations;

namespace MyFinance.Domain.Entities.BaseEntities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Inserido em")]
        public DateTime CreateDate { get; set; }
    }
}
