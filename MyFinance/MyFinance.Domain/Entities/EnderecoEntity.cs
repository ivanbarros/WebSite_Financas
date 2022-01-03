using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Domain.Entities
{
    public class EnderecoEntity
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
    }
}
