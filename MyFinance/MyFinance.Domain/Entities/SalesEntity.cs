using MyFinance.Domain.Entities.BaseEntities;
using MyFinance.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinance.Domain.Entities
{
    [Table("Sales")]
    public class SalesEntity : BaseEntity
    {
        //public List<ProductEntity> Produto { get; set; }
        //public EmployeeEntity Vendedor { get; set; }
        //public PaymentMethodEnum PaymentMethod { get; set; }
        public DateTime DateOut { get; set; }
        public decimal Amount { get; set; }

        [Column("IdProductEntity")]
        public int IdProductEntity { get; set; }
        public virtual ProductEntity Product { get; set; }

        [Column("IdEmployeeEntity")]
        public int IdEmployeeEntity { get; set; }
        [NotMapped]

        public virtual EmployeeEntity Employee { get; set; }

        [Column("IdPaymentMethodEntity")]
        public int IdPaymentMethodEntity { get; set; }
        public virtual PaymentMethodEntity PaymentMethod { get; set; }

        [Column("IdCustomerEntity")]
        public int IdCustomerEntity { get; set; }
        [NotMapped]

        public virtual CustomerEntity Customer { get; set; }
        [NotMapped]

        public ICollection<DevolutionEntity> Devolution { get; set; }



    }
}
