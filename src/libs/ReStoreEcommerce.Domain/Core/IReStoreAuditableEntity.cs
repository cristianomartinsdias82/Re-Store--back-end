namespace ReStoreEcommerce.Domain.Core;

public interface IReStoreAuditableEntity : IReStoreEntity, IAuditableEntity<int>
{
}
