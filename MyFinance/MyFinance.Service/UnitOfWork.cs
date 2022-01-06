﻿using MyFinance.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MyFinance.Service
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private bool _disposed;

        public UnitOfWork(IDbConnection connection)
        {
            Connection = connection;
        }

        public IDbConnection Connection { get; private set; }

        public IDbTransaction Transaction { get; private set; }

        public void BeginTransaction()
        {
            Connection.Open();
            Transaction = Connection.BeginTransaction();
        }

        public void Commit()
        {
            if (Transaction == null)
                throw new ArgumentNullException("Transaction", "Transaction não inicializada, chamar primeiro o BeginTransaction");

            try
            {

                Transaction.Commit();
            }
            catch
            {
                Transaction.Rollback();
                throw;
            }
            finally
            {
                Transaction.Dispose();
            }
        }

        public void Rollback()
        {
            if (Transaction == null)
                throw new ArgumentNullException("Transaction", "Transaction não inicializada, chamar primeiro o BeginTransaction");

            try
            {
                Transaction?.Rollback();
            }
            finally
            {
                Transaction?.Dispose();
            }
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                if (Transaction != null)
                {
                    Transaction.Dispose();
                    Transaction = null;
                }
                if (Connection != null)
                {
                    Connection.Dispose();
                    Connection = null;
                }
                _disposed = true;
            }
        }
    }
}