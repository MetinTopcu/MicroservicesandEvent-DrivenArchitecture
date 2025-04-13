using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using StockManagement.Shared.Domain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StockManagement.Shared.Domain.Services
{
    public class UnitOfWork<TDbContext> : IUnitOfWork<TDbContext> where TDbContext : DbContext
    {
        protected TDbContext DbContext;
        protected IDbContextTransaction? Transaction { get; private set; } = null;

        public UnitOfWork(TDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public void BeginTransaction()
        {
            if (Transaction is null)
                Transaction = DbContext.Database.BeginTransaction();
            else throw new InvalidOperationException("A transaction has already been started.");
        }

        public async Task BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            if (Transaction is null)
                Transaction = await DbContext.Database.BeginTransactionAsync(cancellationToken);
            else throw new InvalidOperationException("A transaction has already been started.");

        }

        public void Commit()
        {
            if (Transaction is null)
                throw new InvalidOperationException("A transaction has not been started.");
            Transaction.Commit();
            DbContext.SaveChanges();
            Transaction.Dispose();
            Transaction = null;
        }

        public async Task CommitAsync(CancellationToken cancellationToken = default)
        {
            if (Transaction is null)
                throw new InvalidOperationException("A transaction has not been started.");
            await Transaction.CommitAsync(cancellationToken);
            await DbContext.SaveChangesAsync(cancellationToken);
            await Transaction.DisposeAsync();
            Transaction = null;
        }

        public void Rollback()
        {
            if (Transaction is null)
                throw new Exception("Transaction is null");
            Transaction.Rollback();
            Transaction.Dispose();
            Transaction = null;
        }

        public async Task RollbackAsync(CancellationToken cancellationToken = default)
        {
            if (Transaction is null)
                throw new Exception("Transaction is null");
            await Transaction.RollbackAsync(cancellationToken);
            await Transaction.DisposeAsync();
            Transaction = null;
        }
    }
}
