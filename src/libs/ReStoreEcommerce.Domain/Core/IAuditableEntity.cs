namespace ReStoreEcommerce.Domain.Core;

public interface IAuditableEntity<TKey> : IEntity<TKey>
{
	string CreatedAtUserId { get; }
	DateTimeOffset CreatedAt { get; }
	string UpdatedAtUserId { get; }
	DateTimeOffset UpdatedAt { get; }
	string DeactivatedAtUserId { get; }
	DateTimeOffset DeactivatedAt { get; }
}
