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
                if (entity.DatePaymentRealized == null || entity.DatePaymentRealized == Convert.ToDateTime("01/01/0001 00:00:00"))
                {
                    entity.DatePaymentRealized = DateTime.MinValue;
                }
                if (entity.PaymentDate == null || entity.PaymentDate == Convert.ToDateTime("01/01/0001 00:00:00"))
                {
                    entity.PaymentDate = DateTime.MinValue;
                }
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

                throw ex;
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
            var registro = _context.CashFlow.Find(entity.Id);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return Task.FromResult(entity);
        }

        public  CashFlowEntity Get(int id)
        {
            var registro =  /*_context.CashFlow.Where(c => c.Id.Equals(id)).FirstOrDefault();*/   _dataset.SingleOrDefault(p => p.Id.Equals(id));
            var cash = new CashFlowEntity {

                Usuario_id = registro.Usuario_id,
                Tipo = registro.Tipo,
                IsPago = registro.IsPago,
                Descricao = registro.Descricao,
                CreateDate = registro.CreateDate,
                Category = registro.Category,
                ValueCash = registro.ValueCash,
                DatePaymentRealized = registro.DatePaymentRealized,
                PaymentDate = registro.PaymentDate,
                Id = registro.Id
            };
            

            return cash;
        }

        public List<CashFlowEntity> GetDespesaReceita(int Id, string decision, string nameCategoria)
        {


            List<CashFlowEntity> result = new List<CashFlowEntity>();
            if (String.IsNullOrEmpty(nameCategoria) && !String.IsNullOrWhiteSpace(decision))
            {

                var lista = _context.CashFlow.Where(c => c.Usuario_id.Equals(Id) && c.Tipo.Equals(decision) && c.IsActive.Equals(true)).ToList();
                var total = lista.Sum(d => Convert.ToDecimal(d.ValueCash));


                return lista;

            }
            if (String.IsNullOrEmpty(nameCategoria) && String.IsNullOrEmpty(decision))
            {
                var lista = _context.CashFlow.Where(c => c.Usuario_id.Equals(Id) && c.IsActive.Equals(true)).ToList();
                result = lista;
                return result;
            }
            else if (!String.IsNullOrEmpty(nameCategoria) && String.IsNullOrWhiteSpace(decision))
            {
                var lista = _context.CashFlow.Where(c => c.Usuario_id.Equals(Id) && c.Category.Equals(nameCategoria) && c.IsActive.Equals(true)).ToList();

                result = lista;
                return result;
            }
            else
            {
                var lista = _context.CashFlow.Where(c => c.Usuario_id.Equals(Id) && c.Tipo.Equals(decision) && c.Category.Equals(nameCategoria) && c.IsActive.Equals(true)).ToList();
                result = lista;
                return result;
            }
        }

        public decimal ValorTotalDespesa(int userId,string categoria, string decision)
        {
            
            if (String.IsNullOrEmpty(categoria) && String.IsNullOrEmpty(decision))
            {
                var lista = _context.CashFlow.Where(c => c.Tipo.Equals("despesa") && c.Usuario_id.Equals(userId)).Sum(c => c.ValueCash);
                return lista;
            }
            else if (!String.IsNullOrEmpty(categoria) && !String.IsNullOrEmpty(decision))
            {

                var lista = _context.CashFlow.Where(c => c.Tipo.Equals("despesa") && c.Category.Equals(categoria) && c.Usuario_id.Equals(userId)).Sum(c => c.ValueCash);
                return lista;

            }
            else if (!String.IsNullOrEmpty(categoria) && String.IsNullOrEmpty(decision))
            {
                var lista = _context.CashFlow.Where(c => c.Category.Equals(categoria) && c.Tipo.Equals("despesa")&& c.Usuario_id.Equals(userId)).Sum(c => c.ValueCash);
                return lista;
               
            }
            
            else if (String.IsNullOrEmpty(categoria) && !String.IsNullOrEmpty(decision))
            {
                var lista = _context.CashFlow.Where(c => c.Tipo.Equals("despesa")&& c.Usuario_id.Equals(userId)).Sum(c => c.ValueCash);
                return lista;
            }
            return 0;


        }

        public decimal ValorReceita(int userId, string nameCategoria, string decision)
        {
            if (String.IsNullOrEmpty(nameCategoria) && String.IsNullOrEmpty(decision))
            {
                var lista = _context.CashFlow.Where(c => c.Tipo.Equals("receita") && c.Usuario_id.Equals(userId)).Sum(c => c.ValueCash);
                return lista;
            }
            else if (!String.IsNullOrEmpty(nameCategoria) && !String.IsNullOrEmpty(decision))
            {

                var lista = _context.CashFlow.Where(c => c.Tipo.Equals("receita") && c.Category.Equals(nameCategoria) && c.Usuario_id.Equals(userId)).Sum(c => c.ValueCash);
                return lista;

            }
            else if (!String.IsNullOrEmpty(nameCategoria) && String.IsNullOrEmpty(decision))
            {
                var lista = _context.CashFlow.Where(c => c.Category.Equals(nameCategoria) && c.Category.Equals("receita") && c.Usuario_id.Equals(userId)).Sum(c => c.ValueCash);
                return lista;

            }

            else if (String.IsNullOrEmpty(nameCategoria) && !String.IsNullOrEmpty(decision))
            {
                var lista = _context.CashFlow.Where(c => c.Tipo.Equals("receita") && c.Usuario_id.Equals(userId)).Sum(c => c.ValueCash);
                return lista;
            }
            return 0;
        }
    }
}
