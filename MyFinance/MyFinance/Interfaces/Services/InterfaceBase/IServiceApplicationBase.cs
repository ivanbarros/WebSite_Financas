﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Interfaces.Services.InterfaceBase
{
    public interface IServiceApplicationBase <T> where T: class 
    {
        Task<IEnumerable<T>> GetAll();
        void Insert(T item);
        void Excluir(int id);
    }
}
