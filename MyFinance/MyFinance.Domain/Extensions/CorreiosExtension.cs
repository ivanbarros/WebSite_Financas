using MyFinance.Domain.Entities;

namespace MyFinance.Domain.Extensions
{
    public static class CorreiosExtension
    {

        public static AddressEntity GetZipCode(AddressEntity end)
        {
            var addresses = new Correios.NET.Services().GetAddresses(end.ZipCode);

            AddressEntity endereco = new AddressEntity();
            foreach (var address in addresses)
            {
                endereco.City = address.City;
                endereco.State = address.State;
                endereco.Street = address.Street;
                endereco.NeighborHood = address.District;
                endereco.ZipCode = address.ZipCode;
                endereco.Complement = end.Complement;
                endereco.Number = end.Number;
            }
            return endereco;
        }
    }
}
