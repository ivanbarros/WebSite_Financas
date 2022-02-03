using MyFinance.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Repository.Interfaces.Repositories
{
    public interface ICashFlowTypeEnumRepository : IRepositoryBase<CashFlowTypeEnum,SqlContext>
    {
    }
}
