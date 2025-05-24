using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ReStoreEcommerce.Infrastructure.Persistence.EFPostgreSql;

namespace Infrastructure.Persistence.DesignTimeMigrationsHelper;

//https://go.microsoft.com/fwlink/?linkid=851728
//https://learn.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli
internal sealed class ReStoreECommerceDbContextFactory : IDesignTimeDbContextFactory<ReStoreECommerceDbContext>
{
    public ReStoreECommerceDbContext CreateDbContext(string[] args)
    {
		var config = new ConfigurationBuilder()
							//https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-9.0&tabs=windows
							.AddUserSecrets("9f3bfb61-06d0-4d77-af99-95f04a20e23f")
                            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<ReStoreECommerceDbContext>();

		optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection"));
		// \%APP_DATA%\Roaming\Microsoft\UserSecrets\9f3bfb61-06d0-4d77-af99-95f04a20e23f

		return new(optionsBuilder.Options);
    }
}
