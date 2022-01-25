using MyFinance.Domain.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyFinance.Domain.Entities
{
    public class StockEntity : BaseEntity
    {
        //public ProductEntity Product { get; set; }
        //public SupplierEntity Supllier {get; set;}
        public int Qtd { get; set; }
        public DateTime DateIn { get; set; }

        [Column("IdUserEntity")]
        public int IdUserEntity { get; set; }
        public virtual UserEntity User { get; set; }

        [Column("IdProductEntity")]
        public int IdProductEntity { get; set; }
        public virtual ProductEntity Product { get; set; }
    }
}
