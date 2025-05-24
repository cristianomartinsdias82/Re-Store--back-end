namespace ReStoreEcommerce.Domain.Core;

public abstract class ReStoreEntity : IReStoreEntity
{
	public int Id { get; private set; }
}
