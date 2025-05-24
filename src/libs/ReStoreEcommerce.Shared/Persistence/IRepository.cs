using System.Linq.Expressions;

namespace ReStoreEcommerce.Shared.Persistence;

public interface IRepository<T, TKey>
{
	Task<T?> GetByIdAsync(TKey key, CancellationToken cancellationToken = default);
	Task<IList<T>> ListAsync(CancellationToken cancellationToken = default);
	Task InsertAsync(T item, CancellationToken cancellationToken = default);
	Task UpdateAsync(T item, CancellationToken cancellationToken = default);
	Task RemoveAsync(TKey key, CancellationToken cancellationToken = default);
	Task<bool> ExistsAsync(Expression<Func<T, bool>> criteria, CancellationToken cancellationToken = default);
}
