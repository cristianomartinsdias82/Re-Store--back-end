using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReStoreEcommerce.Domain.Entities;

namespace ReStoreEcommerce.Infrastructure.Persistence.EFPostgreSql.Mappings;

public sealed class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
{
	public void Configure(EntityTypeBuilder<Product> builder)
	{
		
	}
}
