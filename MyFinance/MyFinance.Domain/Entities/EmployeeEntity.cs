using MyFinance.Domain.Entities.BaseEntities;
using MyFinance.Domain.Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinance.Domain.Entities
{
    public class EmployeeEntity : BaseEntity
    {
        public EnderecoEntity Endereco { get; set; }

        private string nome;

        [Column("Name")]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string sobrenome;

        [Column("LastName")]
        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }

        private DateTime datanasc;

        [Column("DataNascimento")]
        public DateTime DataNascimento
        {
            get { return datanasc; }
            set { datanasc = value; }
        }

        private string cpf;

        [Column("Cpf")]
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string tel;

        [Column("Tel")]
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private DateTime dataAdmissao;

        public DateTime DataAdmissao
        {
            get { return dataAdmissao; }
            set { dataAdmissao = value; }
        }

        private DateTime dataDemissao;

        public DateTime DataDemissao
        {
            get { return dataDemissao; }
            set { dataDemissao = value; }
        }

        public ContractTypeEnum TipoContratacao { get; set; }

        private int cargaHoraDia;

        public int CargaHoraDia
        {
            get { return cargaHoraDia; }
            set { cargaHoraDia = value; }
        }

        private decimal payment;

        [Column("Salario")]
        public decimal Payment
        {
            get { return payment; }
            set { payment = value; }
        }

        private bool isActive;

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }
        [Column("IdUserEntity")]
        public int IdUserEntity { get; set; }
        public virtual UserEntity User { get; set; }

        [Column("IdEndereçoEntity")]
        public int IdEndereçoEntity { get; set; }
        public virtual EnderecoEntity Endereço { get; set; }



    }
}
