using MyFinance.Domain.Entities.BaseEntities;
using MyFinance.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinance.Domain.Entities
{
    public class ProductEntity : BaseEntity
    {
        public string Name { get; set; }
        public TypeClothesEnum TypeProduct { get; set; }
        public decimal UnitValue { get; set; }
        public DateTime ExpirationDate { get; set; }
        public BrandTypeEnum Brand { get; set; }
        public string BarCodeTag { get; set; }
        public DateTime DateIn { get; set; }

        [Column("IdProductTypeEntity")]
        public int IdProductTypeEntity { get; set; }
        public virtual ProductTypeEntity ProductType { get; set; }
        
        [Column("IdSupplierEntity")]
        public int IdSupplierEntity { get; set; }
        public virtual SupplierEntity Supplier { get; set; }

        public ICollection<StockEntity> Stock { get; set; }
        public ICollection<SalesEntity> Sales { get; set; }

    }
}
