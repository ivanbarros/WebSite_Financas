using MyFinance.Domain.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyFinance.Domain.Entities
{
    [Table("ProductTypeEntity")]
    public class ProductTypeEntity : BaseEntity
    {
        [Column("Name")]
        public string Name { get; set; }
        public ICollection<ProductEntity> Product { get; set; }

    }
}
