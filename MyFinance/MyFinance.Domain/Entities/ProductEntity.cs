using MyFinance.Domain.Entities.BaseEntities;
using MyFinance.Domain.Entities.Enums;

namespace MyFinance.Domain.Entities
{
    public class ProductEntity : BaseEntity
    {
        public string Name { get; set; }
        public TypeEnum TypeProduct { get; set; }
        public decimal UnitValue { get; set; }
        public BranchType Branch { get; set; }
        
    }
}
