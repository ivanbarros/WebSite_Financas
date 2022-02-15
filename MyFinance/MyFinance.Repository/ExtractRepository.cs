using Microsoft.EntityFrameworkCore;
using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinance.Repository
{
    public class ExtractRepository : IExtractRepository
    {
        SqlContext _context = new SqlContext();
        private DbSet<ExtractEntity> _dataset;

        public ExtractRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<ExtractEntity>();
        }

        public Task<ExtractEntity> Add(ExtractEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ExtractEntity> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ExtractEntity> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<ExtractEntity>> GetAll()
        {
            var extract = new ExtractEntity();
            var lista = new List<ExtractEntity>();
            #region extrato

            //var extrato = new ExtractEntity
            //{
            //    Account =
            //    {
            //        NomeConta = "Teste",
            //        Saldo = 1.000M,
            //        IsActive = true,
            //        CreateDate = DateTime.Now,
            //        DescriptionAccount = "Teste de descrição de Conta",
            //        AccountType = "corrente",
            //        Id = 1,
            //        Usuario_idUsuario = 1,
            //    },
            //    AccountPlan =
            //    {
            //        CreateDate = DateTime.Now,
            //        Descricao = "Teste Account Plan",
            //        Id = 1,
            //        Tipo = "Sei lá",
            //        Usuario_id = 1
            //    },
            //    Calendar =
            //    {
            //        Color = "000",
            //        CreateDate = DateTime.MinValue,
            //        Start = DateTime.Now,
            //        End = DateTime.Now,
            //        Id=1,
            //        Text = "Isso é um teste de data"
            //    },
            //    CreateDate = DateTime.Now,
            //    Id = 1,
            //    User =
            //    {
            //        Id = 1,
            //        CreateDate = DateTime.Now,
            //        Email = "",
            //        IdPermission = 4,
            //        IsActive = true,
            //    }
            //};
            #endregion extrato
            var extrato = _context.Transaction;
            foreach (var item in extrato)
            {
                extract.Account.AccountType =  item.Account.AccountType;
                extract.Account.DescriptionAccount = item.Account.DescriptionAccount;
                extract.Account.CreateDate = item.Account.CreateDate;
                extract.Account.Saldo = item.Account.Saldo;
                extract.Account.NomeConta = item.Account.NomeConta;
                
            }
            lista.Add(extract);
          
            var result = _context.Extract;
            return await result.ToListAsync();
        }

        public IEnumerable<ExtractEntity> GetByEmail(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<ExtractEntity> Update(ExtractEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
