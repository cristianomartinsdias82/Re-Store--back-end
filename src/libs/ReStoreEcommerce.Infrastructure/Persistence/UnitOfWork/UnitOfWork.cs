using ReStoreEcommerce.Infrastructure.Persistence.EFPostgreSql;
using ReStoreEcommerce.Shared.Persistence;

namespace ReStoreEcommerce.Infrastructure.Persistence.UnitOfWork;

internal class UnitOfWork(ReStoreECommerceDbContext dbContext) : IUnitOfWork
{
	public async Task<int> CommitAsync(CancellationToken cancellationToken = default)
		=> await dbContext.SaveChangesAsync(cancellationToken);

	public Task RollbackAsync(CancellationToken cancellationToken = default)
		=> throw new NotImplementedException();
}
