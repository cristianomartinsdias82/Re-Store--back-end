using ReStoreEcommerce.Domain.Contracts;
using ReStoreEcommerce.Domain.Entities;
using ReStoreEcommerce.Infrastructure.Persistence.EFPostgreSql;

namespace ReStoreEcommerce.Infrastructure.Persistence.Repositories;

internal sealed class ProductRepository(ReStoreECommerceDbContext context)
	: EFRepository<Product>(context), IProductRepository {}