using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Interfaces.Services.InterfaceBase
{
    public interface IServiceApplicationBase <T> where T: class
    {
        List<T> GetAll(T item);
        void Insert(T item);
        void Excluir(int id);
    }
}
