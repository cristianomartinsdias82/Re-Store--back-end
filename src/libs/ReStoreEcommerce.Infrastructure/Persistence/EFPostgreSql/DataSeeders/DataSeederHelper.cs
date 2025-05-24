using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ReStoreEcommerce.Domain.Entities;

namespace ReStoreEcommerce.Infrastructure.Persistence.EFPostgreSql.DataSeeders;

public class DataSeederHelper
{
	public static void SeedDbWithProducts(IServiceProvider provider)
	{
		using var scope = provider.CreateScope();
		var dbContext = scope.ServiceProvider.GetRequiredService<ReStoreECommerceDbContext>();
		var logger = scope.ServiceProvider.GetService<ILogger<ReStoreECommerceDbContext>>();

		if (dbContext.Products.Any())
			return;
	
		logger?.LogInformation("Seeding database with products...");

		dbContext.Products.AddRange(
				Product.Create(
					"RS0001",
					"React Speedster Board 2000",
					"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
					"/images/products/sb-ang1.png",
					"Boards",
					"React",
					20000,
					100
				),
				Product.Create(
					"RS0002",
					"Green React Board 3000",
					"Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
					"/images/products/sb-ang2.png",
					"Boards",
					"React",
					15000,
					100
				),
				Product.Create(
					"RS0003",
					"Core Board Speed Rush 3",
					"Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
					"/images/products/sb-core1.png",
					"Boards",
					"NetCore",
					18000,
					100
				),
				Product.Create(
					"RS0004",
					"Net Core Super Board",
					"Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
					"/images/products/sb-core2.png",
					"Boards",
					"NetCore",
					30000,
					100
				),
				Product.Create(
					"RS0005",
					"React Board Super Whizzy Fast",
					"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
					"/images/products/sb-react1.png",
					"Boards",
					"React",
					25000,
					100
				),
				Product.Create("RS0006",
					"Typescript Entry Board",
					"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
					"/images/products/sb-ts1.png",
					"Boards",
					"TypeScript",
					12000,
					100
				),
				Product.Create(
					"RS0007",
					"Core Blue Hat",
					"Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
					"/images/products/hat-core1.png",
					"Hats",
					"NetCore",
					1000,
					100
				),
				Product.Create(
					"RS0008",
					"Green React Woolen Hat",
					"Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
					"/images/products/hat-react1.png",
					"Hats",
					"React",
					8000,
					100
				),
				Product.Create(
					"RS0009",
					"Purple React Woolen Hat",
					"Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
					"/images/products/hat-react2.png",
					"Hats",
					"React",
					1500,
					100
				),
				Product.Create(
					"RS0010",
					"Blue Code Gloves",
					"Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
					"/images/products/glove-code1.png",
					"Gloves",
					"VS Code",
					1800,
					100
				),
				Product.Create(
					"RS0011",
					"Green Code Gloves",
					"Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
					"/images/products/glove-code2.png",
					"Gloves",
					"VS Code",
					1500,
					100
				),
				Product.Create(
					"RS0012",
					"Purple React Gloves",
					"Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
					"/images/products/glove-react1.png",
					"Gloves",
					"React",
					1600,
					100
				),
				Product.Create(
					"RS0013",
					"Green React Gloves",
					"Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
					"/images/products/glove-react2.png",
					"Gloves",
					"React",
					1400,
					100
				),
				Product.Create(
					"RS0014",
					"Redis Red Boots",
					"Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
					"/images/products/boot-redis1.png",
					"Boots",
					"Redis",
					25000,
					100
				),
				Product.Create(
					"RS0015",
					"Core Red Boots",
					"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
					"/images/products/boot-core2.png",
					"Boots",
					"NetCore",
					18999,
					100
				),
				Product.Create(
					"RS0016",
					"Core Purple Boots",
					"Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
					"/images/products/boot-core1.png",
					"Boots",
					"NetCore",
					19999,
					100
				),
				Product.Create(
					"RS0017",
					"React Purple Boots",
					"Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
					"/images/products/boot-ang2.png",
					"Boots",
					"React",
					15000,
					100
				),
				Product.Create(
					"RS0018",
					"React Blue Boots",
					"Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
					"/images/products/boot-ang1.png",
					"Boots",
					"React",
					18000,
					100
				)
			);

		dbContext.SaveChanges();

		logger?.LogInformation("Database seed successful.");
	}
}
