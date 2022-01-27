using MyFinance.Domain.Entities.BaseEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinance.Domain.Entities
{
    public class AddressEntity : BaseEntity
    {

        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string Number{ get; set; }
        public string Complement { get; set; }
        public string NeighborHood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [NotMapped]

        public ICollection<EmployeeEntity> Employee { get; set; }
    }
}
