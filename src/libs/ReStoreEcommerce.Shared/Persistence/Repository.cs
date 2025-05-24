using System.Linq.Expressions;

namespace ReStoreEcommerce.Shared.Persistence;

public abstract class Repository<T, TKey> : IRepository<T, TKey>
{
	public abstract Task<T?> GetByIdAsync(TKey key, CancellationToken cancellationToken = default);
	public abstract Task<IList<T>> ListAsync(CancellationToken cancellationToken = default);
	public abstract Task RemoveAsync(TKey key, CancellationToken cancellationToken = default);
	public abstract Task InsertAsync(T item, CancellationToken cancellationToken = default);
	public abstract Task UpdateAsync(T item, CancellationToken cancellationToken = default);
	public abstract Task<bool> ExistsAsync(Expression<Func<T, bool>> criteria, CancellationToken cancellationToken = default);
}
