using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using MyFinance.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Repository.Interfaces.Repositories
{
    public interface ICashFlowTypeEnumRepository : IRepositoryBase<CashFlowTypeEnumEntity,SqlContext>
    {
    }
}
