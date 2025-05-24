namespace ReStoreEcommerce.Shared.Persistence;

public interface IUnitOfWork
{
	Task<int> CommitAsync(CancellationToken cancellationToken = default);
	Task RollbackAsync(CancellationToken cancellationToken = default);
}