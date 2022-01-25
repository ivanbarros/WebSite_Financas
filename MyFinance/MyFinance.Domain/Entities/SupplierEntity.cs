using MyFinance.Domain.Entities.BaseEntities;
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
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private bool isActive;

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public AddressEntity Endereco { get; set; }
    }
}

    
        
      




    