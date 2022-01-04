using MyFinance.Domain.Entities.BaseEntities;
using System;
using System.Collections.Generic;

namespace MyFinance.Domain.Entities
{
    public class SalesEntity : BaseEntity
    {
        public List<ProductEntity> Produto { get; set; }
        public int Qtd { get; set; }
        public EmployeeEntity Vendedor { get; set; }
        public DateTime DataCompra { get; set; }
        public decimal ValorTotal { get; set; }



    }
}
