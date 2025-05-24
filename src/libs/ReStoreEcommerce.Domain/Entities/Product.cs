using ReStoreEcommerce.Domain.Core;

namespace ReStoreEcommerce.Domain.Entities;

public class Product : ReStoreEntity
{
	private Product() { }

	public string Sku { get; private set; } = default!;
	public string Name { get; private set; } = default!;
	public string Description { get; private set; } = default!;
	public string PictureUrl { get; private set; } = default!;
	public string Type { get; private set; } = default!;
	public string Brand { get; private set; } = default!;
	public long Price { get; private set; } = default!;
	public int QuantityInStock { get; private set; } = default!;

	public static Product Create(
		string sku,
		string name,
		string description,
		string pictureUrl,
		string type,
		string brand,
		long price,
		int quantityInStock)
		=> new Product
		{
			Sku = sku,
			Name = name,
			Description = description,
			PictureUrl = pictureUrl,
			Type = type,
			Brand = brand,
			Price = price,
			QuantityInStock = quantityInStock
		};

	public Product SetName(string name) { Name = name; return this; }
	public Product SetSku(string sku) { Sku = sku; return this; }
	public Product SetDescription(string description) { Description = description; return this; }
	public Product SetPrice(long price) { Price = price; return this; }
	public Product SetQuantityInStock(int quantityInStock) { QuantityInStock = quantityInStock; return this; }
	public Product SetPictureUrl(string pictureUrl) { PictureUrl = pictureUrl; return this; }
	public Product SetBrand(string brand) { Brand = brand; return this; }
	public Product SetType(string type) { Type = type; return this; }
}
