using MyFinance.Domain.Entities;
using MyFinance.Interfaces.Services;
using MyFinance.Service.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.ServicesApplication
{
    public class CashFlowServiceApplication : ICashFlowServiceApplication
    {
        private readonly ICashFlowService _service;

        public CashFlowServiceApplication(ICashFlowService service)
        {
            _service = service;
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CashFlowEntity>> GetAll()
        {
            return _service.GetAll();
        }

        public void Add(CashFlowEntity item)
        {

            _service.Insert(item);
        }


        public void Insert(CashFlowEntity item)
        {
            _service.Insert(item);
        }

        public List<CashFlowEntity> GetDespesaReceita(int Id, string decision, string nameCategoria)
        {
            var result = _service.GetDespesaReceita(Id, decision, nameCategoria);
            return result;
        }

        public Task<CashFlowEntity> Update(CashFlowEntity entity)
        {
            var result = _service.Update(entity);
            return result;
        }

        public CashFlowEntity Get(int id)
        {
            var result =  _service.Get(id);
            //CashFlowEntity cash = new CashFlowEntity();
            //foreach (var item in result.ValueCash.ToString())
            //{
            //    if (result.Tipo == "despesa")
            //    {

            //        cash.ValorTotalDespesa += item;
            //        cash.ValorTotalReceita = 0.0M;
            //    }
            //    if (result.Tipo == "receita")
            //    {
            //        cash.ValorTotalReceita += item;
            //    }
            //}
            return result;
        }

        public decimal ValorTotalDespesa(int userId, string categoria, string decision)
        {
            var result = _service.ValorTotalDespesa(userId, categoria, decision);
            return result;
        }

        public decimal ValorTotalReceita(int userId, string categoryName, string decision)
        {
            var result = _service.ValorTotalReceita(userId, categoryName, decision);
            return result;
        }
    }
}
