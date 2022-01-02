using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Repository.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        List<T> GetAll(ContaEntity conta);
        void Insert(ContaEntity conta);
        void Excluir(int id);
    }
}
