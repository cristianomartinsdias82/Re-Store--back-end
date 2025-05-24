
namespace ReStoreEcommerce.Application.Common;

public record ProductDto
{
	public int? Id { get; init; }
	public required string Sku { get; init; } = default!;
	public required string Name { get; init; } = default!;
	public required string Description { get; init; } = default!;
	public required string PictureUrl { get; init; } = default!;
	public required string Type { get; init; } = default!;
	public required string Brand { get; init; } = default!;
	public required long Price { get; init; } = default!;
	public required int QuantityInStock { get; init; } = default!;
}
