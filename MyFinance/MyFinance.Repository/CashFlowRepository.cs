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
    public class CashFlowRepository : ICashFlowRepository
    {
        SqlContext _context = new SqlContext();
        private DbSet<CashFlowEntity> _dataset;

        public CashFlowRepository(SqlContext context)
        {
            _context = context;
            _dataset = context.Set<CashFlowEntity>();

        }

        public Task<CashFlowEntity> Add(CashFlowEntity entity)
        {
            try
            {
                entity.Tipo = Convert.ToString(entity.TipoCashEnum);
                _dataset.Add(entity);
                _context.SaveChanges();
                return Task.FromResult(entity);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public Task<CashFlowEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CashFlowEntity> GetById(int id)
        {
            //List<CashFlowEntity> cashflow = new List<CashFlowEntity>();

            //var result = _context.CashFlow.Where(c =>c.Usuario_id.Equals(id)).ToList();

            //foreach (var item in result)
            //{
            //    cashflow.Add(item);
            //}
            //return cashflow;

            throw new NotImplementedException();
        }

        public Task<IEnumerable<CashFlowEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CashFlowEntity> GetByEmail(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<CashFlowEntity> Update(CashFlowEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<CashFlowEntity> Get(int id)
        {
            //var result =  await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));

            //return result;
            throw new NotImplementedException();
        }

        public List<CashFlowEntity> ListaPlanoContas(int id)
        {
            List<CashFlowEntity> lista = new List<CashFlowEntity>();

            var result = _context.CashFlow.Where(c => c.Usuario_id.Equals(id)).ToList();

            foreach (var item in result)
            {
                lista.Add(item);
            }
            return lista;
            //throw new NotImplementedException();
        }
    }
}
