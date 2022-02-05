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
                entity.CreateDate = DateTime.Now;
                entity.Category = Convert.ToString(entity.CategoryEnum);
                entity.IsActive = true;
                if (entity.Pago.ToString() == "Sim")
                {
                    entity.IsPago = true;
                }
                else
                {
                    entity.IsPago = false;
                }

                _dataset.Add(entity);
                _context.SaveChanges();
                return Task.FromResult(entity);
            }
            catch (Exception ex)
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

        public Task<CashFlowEntity> Get(int id)
        {
            throw new NotImplementedException();
        }
        
        public List<CashFlowEntity> GetDespesaReceita(int Id,string decision, string nameCategoria)
        {
            List<CashFlowEntity> result;
            if (String.IsNullOrEmpty(nameCategoria) && !String.IsNullOrWhiteSpace(decision))
            {
                var lista = _context.CashFlow.Where(c => c.Usuario_id.Equals(Id) && c.Tipo.Equals(decision) && c.IsActive.Equals(true)).ToList();
                result = lista;
            }
            else if (!String.IsNullOrEmpty(nameCategoria) && String.IsNullOrWhiteSpace(decision))
            {
                var lista = _context.CashFlow.Where(c => c.Usuario_id.Equals(Id) &&  c.Category.Equals(nameCategoria) && c.IsActive.Equals(true)).ToList();
                result = lista;
            }
            else
            {
                var lista = _context.CashFlow.Where(c => c.Usuario_id.Equals(Id) && c.Tipo.Equals(decision) && c.Category.Equals(nameCategoria) && c.IsActive.Equals(true)).ToList();
                result = lista;
            }
            if (String.IsNullOrEmpty(nameCategoria)&& String.IsNullOrEmpty(decision))
            {
                var lista = _context.CashFlow.Where(c => c.Usuario_id.Equals(Id) && c.IsActive.Equals(true)).ToList();
                result = lista;
            }
            return result;
        }
    }
}
