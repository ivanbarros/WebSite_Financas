using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Repository.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        List<T> GetAll(T conta);
        void Insert(T conta);
        void Excluir(int id);
    }
}
