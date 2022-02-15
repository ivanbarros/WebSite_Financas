using MyFinance.Domain.Entities;
using MyFinance.Repository.Interfaces.Repositories;
using MyFinance.Service.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFinance.Service
{
    public class CashFlowService : ICashFlowService
    {
        private readonly ICashFlowRepository _repository;

        public CashFlowService(ICashFlowRepository repository)
        {
            _repository = repository;
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CashFlowEntity>> GetAll()
        {
            var result = _repository.GetAll();
            return result;
        }

        public void Add(CashFlowEntity item)
        {
            _repository.Add(item);
        }



        public void Insert(CashFlowEntity item)
        {
            _repository.Add(item);
        }

        public List<CashFlowEntity> GetDespesaReceita(int Id, string decision, string nameCategoria)
        {

            switch (nameCategoria)
            {
                case "0":
                    nameCategoria = "mercado";
                    break;

                case "1":
                    nameCategoria = "lazer";
                    break;

                case "2":
                    nameCategoria = "contas";
                    break;

                case "3":
                    nameCategoria = "vestuario";
                    break;

                case "4":
                    nameCategoria = "saude";
                    break;

                case "5":
                    nameCategoria = "salario";
                    break;

                case "6":
                    nameCategoria = "poupança";
                    break;
                case "7":
                    nameCategoria = "recebimento por Boleto";
                    break;

                case "8":
                    nameCategoria = "pix";
                    break;

                case "9":
                    nameCategoria = "Depósito Bancário";
                    break;

                case "10":
                    
                    nameCategoria = "Transferência Bancária";
                    break;

                default:
                    break;
            }

            switch (decision)
            {
                case "0":
                    decision = "receita";
                    break;

                case "1":
                    decision = "despesa";
                    break;
                default:
                    break;
            }
            var result = _repository.GetDespesaReceita(Id, decision, nameCategoria);

            List<CashFlowEntity> lista = new List<CashFlowEntity>();

            foreach (var item in result)
            {
                lista.Add(item);
            }

            return lista;
        }

        public Task<CashFlowEntity> Update(CashFlowEntity item)
        {
            var result = _repository.Update(item);
            return result;
        }

        public Task<CashFlowEntity> Get(int id)
        {
            var result = _repository.Get(id);
            return result;
        }

        public decimal ValorTotalDespesa(int userId, string nameCategoria, string decision)
        {
            switch (nameCategoria)
            {
                case "0":
                    nameCategoria = "mercado";
                    break;

                case "1":
                    nameCategoria = "lazer";
                    break;

                case "2":
                    nameCategoria = "contas";
                    break;

                case "3":
                    nameCategoria = "vestuario";
                    break;

                case "4":
                    nameCategoria = "saude";
                    break;

                case "5":
                    nameCategoria = "salario";
                    break;

                case "6":
                    nameCategoria = "poupança";
                    break;

                default:
                    break;
            }

            switch (decision)
            {
                case "0":
                    decision = "receita";
                    break;

                case "1":
                    decision = "despesa";
                    break;
                default:
                    break;
            }
            var result = _repository.ValorTotalDespesa(userId, nameCategoria, decision);
            return result;
        }

        public decimal ValorTotalReceita(int userId, string nameCategoria, string decision)
        {
            switch (nameCategoria)
            {
                case "0":
                    nameCategoria = "mercado";
                    break;

                case "1":
                    nameCategoria = "lazer";
                    break;

                case "2":
                    nameCategoria = "contas";
                    break;

                case "3":
                    nameCategoria = "vestuario";
                    break;

                case "4":
                    nameCategoria = "saude";
                    break;

                case "5":
                    nameCategoria = "salario";
                    break;

                case "6":
                    nameCategoria = "poupança";
                    break;

                default:
                    break;
            }

            switch (decision)
            {
                case "0":
                    decision = "receita";
                    break;

                case "1":
                    decision = "despesa";
                    break;
                default:
                    break;
            }
            var result = _repository.ValorReceita(userId, nameCategoria, decision);
            return result;
        }


    }
}
