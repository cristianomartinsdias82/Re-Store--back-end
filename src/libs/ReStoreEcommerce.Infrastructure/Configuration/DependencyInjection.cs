using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReStoreEcommerce.Infrastructure.Persistence.Configuration;

namespace ReStoreEcommerce.Infrastructure.Configuration;

public static class DependencyInjection
{
	public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddPersistence(configuration);

		return services;
	}
}
