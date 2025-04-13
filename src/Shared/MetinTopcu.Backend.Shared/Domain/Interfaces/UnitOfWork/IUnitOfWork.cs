using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Shared.Domain.Interfaces.UnitOfWork
{
    public interface IUnitOfWork<TDbContext>
    {
        Task BeginTransactionAsync(CancellationToken cancellationToken = default(CancellationToken));
        void BeginTransaction();
        Task CommitAsync(CancellationToken cancellationToken = default(CancellationToken));
        void Commit();
        Task RollbackAsync(CancellationToken cancellationToken = default(CancellationToken));
        void Rollback();
    }
}
