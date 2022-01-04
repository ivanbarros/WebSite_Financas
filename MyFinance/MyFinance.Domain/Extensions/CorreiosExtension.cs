using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Domain.Extensions
{
    public static class CorreiosExtension
    {

        public static EnderecoEntity GetZipCode(EnderecoEntity end)
        {
            var addresses = new Correios.NET.Services().GetAddresses(end.Cep);

            EnderecoEntity endereco = new EnderecoEntity();
            foreach (var address in addresses)
            {
                endereco.Cidade = address.City;
                endereco.Estado = address.State;
                endereco.Logradouro = address.Street;
                endereco.Bairro = address.District;
                endereco.Cep = address.ZipCode;
                endereco.Complemento = end.Complemento;
                endereco.Numero = end.Numero;
            }
            return endereco;
        }
    }
}
