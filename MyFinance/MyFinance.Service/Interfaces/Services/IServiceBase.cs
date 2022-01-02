using System.Collections.Generic;

namespace MyFinance.Service.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        List<T> GetAll(T item);
        void Insert( T item);
        void Excluir(int id);
    }
}
