using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ReStoreEcommerce.Domain.Core;
using ReStoreEcommerce.Infrastructure.Persistence.EFPostgreSql;
using System.Linq.Expressions;

namespace ReStoreEcommerce.Infrastructure.Persistence.Repositories;

internal abstract class EFRepository<T>(ReStoreECommerceDbContext dbContext) : ReStoreRepository<T> where T : class, IReStoreEntity
{
	public async override Task<IList<T>> ListAsync(CancellationToken cancellationToken = default)
		=> await dbContext
					.Set<T>()
					.AsNoTracking()
					.ToListAsync(cancellationToken);

	public override async Task<T?> GetByIdAsync(int key, CancellationToken cancellationToken = default)
		=> await dbContext
					.Set<T>()
					.FindAsync([key], cancellationToken);

	public override async Task RemoveAsync(int key, CancellationToken cancellationToken = default)
	{
		var item = await GetByIdAsync(key, cancellationToken);

		if (item is null)
			return;

		dbContext.Entry(item).State = EntityState.Deleted;
	}

	public override async Task<bool> ExistsAsync(Expression<Func<T, bool>> criteria, CancellationToken cancellationToken = default)
		=> await dbContext
					.Set<T>()
					.AnyAsync(criteria, cancellationToken);

	public override async Task InsertAsync(T item, CancellationToken cancellationToken = default)
	{
		await dbContext
				.Set<T>()
				.AddAsync(item, cancellationToken);
	}

	public override async Task UpdateAsync(T item, CancellationToken cancellationToken = default)
	{
		var existingItem = await GetByIdAsync(item.Id, cancellationToken);

		if (existingItem is null)
			return;

		dbContext.Entry(item).State = EntityState.Modified;
	}
}
