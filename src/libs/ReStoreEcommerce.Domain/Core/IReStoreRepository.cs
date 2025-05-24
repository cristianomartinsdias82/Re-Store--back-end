using ReStoreEcommerce.Shared.Persistence;

namespace ReStoreEcommerce.Domain.Core;

public interface IReStoreRepository<T> : IRepository<T, int> where T : IReStoreEntity
{
}
