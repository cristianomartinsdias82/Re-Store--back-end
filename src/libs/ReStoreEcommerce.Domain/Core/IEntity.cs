namespace ReStoreEcommerce.Domain.Core;

public interface IEntity<TKey>
{
	TKey Id { get; }
}