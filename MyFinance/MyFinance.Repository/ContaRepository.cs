using Microsoft.AspNetCore.Http;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace MyFinance.Repository
{
    public class ContaRepository : IContaRepository
    {

        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public ContaRepository(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContaEntity> GetAll(ContaEntity conta)
        {
            throw new NotImplementedException();
        }

        public void Insert(ContaEntity conta)
        {
            throw new NotImplementedException();
        }
    }
}
