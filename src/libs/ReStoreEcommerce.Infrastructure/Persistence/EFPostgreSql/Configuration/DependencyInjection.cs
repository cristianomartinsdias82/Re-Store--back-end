using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ReStoreEcommerce.Infrastructure.Persistence.EFPostgreSql.Configuration;

internal static class DependencyInjection
{
	public static void AddEFPostgreSql(
		this IServiceCollection services,
		IConfiguration configuration)
	{
		services.AddDbContext<ReStoreECommerceDbContext>(options =>
		{
			options.UseNpgsql(
				configuration.GetConnectionString("DefaultConnection"),
				npgOptions =>
				{
					npgOptions.EnableRetryOnFailure(3);
				});
		});
	}
}
