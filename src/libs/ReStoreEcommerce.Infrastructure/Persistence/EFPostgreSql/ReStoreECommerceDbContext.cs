using Microsoft.EntityFrameworkCore;
using ReStoreEcommerce.Domain.Entities;

namespace ReStoreEcommerce.Infrastructure.Persistence.EFPostgreSql;

internal sealed class ReStoreECommerceDbContext(DbContextOptions<ReStoreECommerceDbContext> options) : DbContext(options)
{
	public DbSet<Product> Products { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.HasDefaultSchema("Catalog");

		//modelBuilder.ApplyConfigurationsFromAssembly(typeof(ReStoreECommerceDbContext).Assembly);

		//modelBuilder.Entity<Product>() //It didn't work -> 42P01: missing FROM-clause entry for table "product"
		//			.ToTable(nameof(Product), tableBuilder =>
		//			{
		//				tableBuilder.HasCheckConstraint(
		//					$"CK_{nameof(Product)}_QuantityInStock_NonNegative",
		//					sql: $"{nameof(Product)}.{nameof(Product.QuantityInStock)} >= 0");
		//			});

		modelBuilder.Entity<Product>()
					.HasIndex(x => x.Sku, "IX_Product_Sku")
					.IsUnique();

		modelBuilder.Entity<Product>()
					.HasIndex(x => x.Name, "IX_Product_Name")
					.IsUnique();

		base.OnModelCreating(modelBuilder);
	}
}
