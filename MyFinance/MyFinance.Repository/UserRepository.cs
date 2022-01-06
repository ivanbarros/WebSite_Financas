using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace MyFinance.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly SqlContextt _context;

        public UserRepository(SqlContextt context)
        {
            _context = context;
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserEntity> GetAll(UserEntity conta)
        {
            throw new NotImplementedException();
        }

        public void Insert(UserEntity conta)
        {
            _context.Usuario.Add(conta);
            _context.SaveChanges();
        }
    }
}
