using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Repository.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        List<T> GetAll(T item);
        void Insert(T item);
        void Excluir(int id);
    }
}
