using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReStoreEcommerce.Domain.Contracts;
using ReStoreEcommerce.Infrastructure.Persistence.EFPostgreSql.Configuration;
using ReStoreEcommerce.Infrastructure.Persistence.Repositories;
using ReStoreEcommerce.Shared.Persistence;

namespace ReStoreEcommerce.Infrastructure.Persistence.Configuration;

internal static class DependencyInjection
{
	public static void AddPersistence(
		this IServiceCollection services,
		IConfiguration configuration)
	{
		services.AddEFPostgreSql(configuration);

		services.AddScoped<IProductRepository, ProductRepository>();

		services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
	}
}