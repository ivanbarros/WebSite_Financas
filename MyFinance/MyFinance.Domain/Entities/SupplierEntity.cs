using MyFinance.Domain.Entities.BaseEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinance.Domain.Entities
{
    [Table("Supplier")]
    public class SupplierEntity : BaseEntity
    {
        private string nome;

        [Column("Name")]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string cnpj;

        [Column("Cnpj")]
        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }

        }
        public AddressEntity Endereco { get; set; }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private int tel;
        public int Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        private bool isActive;
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }
        public ICollection<ProductEntity> Product { get; set; }
    }
}

    
        
      




    