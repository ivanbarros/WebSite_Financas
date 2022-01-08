using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyFinance.Domain.Entities.BaseEntities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
