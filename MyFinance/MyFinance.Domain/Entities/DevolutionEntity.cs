using MyFinance.Domain.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyFinance.Domain.Entities
{
    [Table("Devolution")]
    public class DevolutionEntity : BaseEntity
    {
        public DateTime DateDevolution { get; set; }

        [Column("IdCustomerEntity")]
        public int IdCustomerEntity { get; set; }
        public virtual CustomerEntity Customer { get; set; }

        [Column("IdSalesEntity")]
        public int IdSalesEntity { get; set; }
        public virtual SalesEntity Sales { get; set; }
    }
}
