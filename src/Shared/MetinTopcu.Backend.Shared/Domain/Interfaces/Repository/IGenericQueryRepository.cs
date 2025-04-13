using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MetinTopcu.Backend.src.Domain.Interfaces;

namespace MetinTopcu.Backend.src.Domain.Interfaces.Repository
{
    public interface IGenericQueryRepository<T, U> where T : IEntity<U> where U : struct
    {
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<IEnumerable<T>> WhereAsync(Expression<Func<T, bool>> selector, CancellationToken cancellationToken = default);
        Task<T?> GetByIdAsync(U id, CancellationToken cancellationToken = default);
        Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> selector, CancellationToken cancellationToken = default);
        Task<T?> LastOrDefaultAsync(Expression<Func<T, bool>> selector, CancellationToken cancellationToken = default);
        Task<int> CountAsync(Expression<Func<T, bool>> selector, CancellationToken cancellationToken = default);
        Task<bool> AnyAsync(Expression<Func<T, bool>> selector, CancellationToken cancellationToken = default);
    }
}
