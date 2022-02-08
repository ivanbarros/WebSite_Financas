using MyFinance.Domain.Entities;
using MyFinance.Domain.Entities.Enums;
using MyFinance.Interfaces.Services.InterfaceBase;
using System.Collections.Generic;

namespace MyFinance.Interfaces.Services
{
    public interface ICashFlowTypeEnumServiceApplication : IServiceApplicationBase<CashFlowTypeEnumEntity>
    {
        public new void Excluir(int id)
        {
            throw new System.NotImplementedException();
        }

        public new IEnumerable<CashFlowTypeEnum> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public new void Insert(CashFlowTypeEnum item)
        {
            throw new System.NotImplementedException();
        }
    }
}
