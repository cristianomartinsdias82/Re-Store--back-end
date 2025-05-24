using ReStoreEcommerce.Infrastructure.Persistence.EFPostgreSql.DataSeeders;

namespace ReStoreEcommerceApi.Core;

public static class AppExtensions
{
	public static void UseDatabaseSeeder(this WebApplication app)
		=> DataSeederHelper.SeedDbWithProducts(app.Services);
}
