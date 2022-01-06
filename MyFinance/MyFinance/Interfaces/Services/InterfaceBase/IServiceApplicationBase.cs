using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Interfaces.Services.InterfaceBase
{
    public interface IServiceApplicationBase <T> where T: class
    {
        Task<List<T>> GetAll();
        void Insert(T item);
        void Excluir(int id);
    }
}
