using MyFinance.Domain.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
