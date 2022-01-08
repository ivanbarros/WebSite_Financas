using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MyFinance.Domain.UnitOfWorkConfig.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IDbTransaction _dbTransaction { get; }

        
        IDbConnection Connection { get; }
        IDbTransaction Transaction { get; }
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
