using MyFinance.Domain.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyFinance.Domain.Entities
{
    [Table("TypeContract")]
    public class TypeContractEntity : BaseEntity
    {
        [Column("Name")]
        public string Name { get; set; }
        public ICollection<EmployeeEntity> Employee { get; set; }
    }
}
