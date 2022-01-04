﻿using MyFinance.Domain.Entities.BaseEntities;
using MyFinance.Domain.Entities.Enums;

namespace MyFinance.Domain.Entities
{
    public class ProductEntity : BaseEntity
    {
        public string Name { get; set; }
        public TypeEnum TypeProduct { get; set; }
        public decimal UnitValue { get; set; }
        public BrandTypeEnum Brand { get; set; }
        public string BarCodeTag { get; set; }

    }
}
