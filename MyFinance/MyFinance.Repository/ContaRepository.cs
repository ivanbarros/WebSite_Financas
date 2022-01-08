using Microsoft.AspNetCore.Http;
using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFinance.Repository
{
    public class ContaRepository : IContaRepository
    {
        private readonly SqlContextt _context;

        public ContaRepository(SqlContextt context)
        {
            _context = context;
        }


       

        public List<ContaEntity> GetAll(ContaEntity conta)

        //public IHttpContextAccessor HttpContextAccessor { get; set; }

        //public ContaRepository(IHttpContextAccessor httpContextAccessor)
        //{
        //    HttpContextAccessor = httpContextAccessor;
        //}

        public void Excluir(int id)

        {
            throw new NotImplementedException();
        }

        public void Insert(ContaEntity conta)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContaEntity> ListaConta(string login, string senha)
        {  
            var result = _context.Set<ContaEntity>().ToList().Where(c => c.NomeConta == login);
            return result.ToList();
        }
    }
}
