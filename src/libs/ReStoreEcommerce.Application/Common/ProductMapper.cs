using ReStoreEcommerce.Domain.Entities;

namespace ReStoreEcommerce.Application.Common;

internal static class ProductMapper
{
	public static ProductDto ToDto(this Product product)
		=> new()
		{
			Id = product.Id,
			Brand = product.Brand,
			Name = product.Name,
			Description = product.Description,
			PictureUrl = product.PictureUrl,
			Price = product.Price,
			QuantityInStock = product.QuantityInStock,
			Sku = product.Sku,
			Type = product.Type
		};
}
