﻿using MyFinance.Data.Context;
using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Repository.Interfaces.Repositories
{
    public interface ITypeContractRepository : IRepositoryBase<TypeContractEntity,SqlContext>
    {

    }
}
