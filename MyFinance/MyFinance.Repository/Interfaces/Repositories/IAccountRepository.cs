﻿using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using System.Collections.Generic;

namespace MyFinance.Repository.Interfaces.Repositories
{
    public interface IAccountRepository : IRepositoryBase<AccountEntity,SqlContext>
    {
        List<AccountEntity> ListaConta(int id);
        
    }
}
