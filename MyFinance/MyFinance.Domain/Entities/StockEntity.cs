using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Domain.Entities
{
    public class StockEntity
    {
        public ProductEntity Product { get; set; }
        public int Qtd { get; set; }
    }
}
