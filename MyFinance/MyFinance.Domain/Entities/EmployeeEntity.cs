using MyFinance.Domain.Entities.BaseEntities;
using MyFinance.Domain.Entities.Enums;
using System;

namespace MyFinance.Domain.Entities
{
    public class EmployeeEntity : BaseEntity
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string sobrenome;

        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }

        private DateTime datanasc;

        public DateTime DataNascimento
        {
            get { return datanasc; }
            set { datanasc = value; }
        }

        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string tel;

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

        private DateTime dataSdmissao;

        public DateTime DataAdmissao
        {
            get { return dataSdmissao; }
            set { dataSdmissao = value; }
        }

        private DateTime dataDemissao;

        public DateTime DataDemissao
        {
            get { return dataDemissao; }
            set { dataDemissao = value; }
        }

        public ContractTypeEnum TipoContrato { get; set; }

        private int cargaHoraDia;

        public int CargaHoraDia
        {
            get { return cargaHoraDia; }
            set { cargaHoraDia = value; }
        }


        public EnderecoEntity Endereco { get; set; }

    }
}
