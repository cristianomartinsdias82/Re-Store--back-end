using ReStoreEcommerce.Shared.Persistence;
using System.Linq.Expressions;

namespace ReStoreEcommerce.Domain.Core;

public abstract class ReStoreRepository<T> : Repository<T, int>, IReStoreRepository<T> where T : IReStoreEntity
{
	public override bool Equals(object? obj)
	{
		return base.Equals(obj);
	}

	public override Task<T?> GetByIdAsync(int key, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override Task<IList<T>> ListAsync(CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public override Task RemoveAsync(int key, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public override Task InsertAsync(T item, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public override Task UpdateAsync(T item, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public override Task<bool> ExistsAsync(Expression<Func<T, bool>> criteria, CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}
}
