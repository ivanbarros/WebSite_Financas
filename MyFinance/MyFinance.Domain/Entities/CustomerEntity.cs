using MyFinance.Domain.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyFinance.Domain.Entities
{
    [Table("Customer")]
    public class CustomerEntity : BaseEntity
    {
        private string nome;

        [Column("Name")]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string cpf;

        [Column("Cpf")]
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }

        }
        private DateTime datebirth;
        public DateTime DateBirth
        {
            get { return datebirth; }
            set { datebirth = value; }
        }
        public bool IsActive;
        private bool isActive
        {
            get { return isActive; }
            set { isActive = value; }
        }
        public AddressEntity Endereco { get; set; }
        public ICollection<SalesEntity> Sales { get; set; }
        public ICollection<DevolutionEntity> Devolution { get; set; }
    }

}
        



