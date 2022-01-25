using MyFinance.Domain.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Domain.Entities
{
    public class AddressEntity : BaseEntity
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public ICollection<EmployeeEntity> Employee { get; set; }
    }
}
