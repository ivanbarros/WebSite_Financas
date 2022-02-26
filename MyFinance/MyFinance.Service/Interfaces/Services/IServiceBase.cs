using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Service.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        void Insert( T item);
        void Excluir(int id);
        Task<T> Update(T item);
        T Get(int id);

    }
}
