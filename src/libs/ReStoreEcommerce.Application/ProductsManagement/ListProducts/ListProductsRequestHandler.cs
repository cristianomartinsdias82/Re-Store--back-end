using MediatR;
using ReStoreEcommerce.Application.Common;
using ReStoreEcommerce.Domain.Contracts;

namespace ReStoreEcommerce.Application.ProductsManagement.ListProducts;

internal sealed class ListProductsRequestHandler(IProductRepository repository) : IRequestHandler<ListProductsRequest, ListProductsResponse>
{
	public async Task<ListProductsResponse> Handle(
		ListProductsRequest request,
		CancellationToken cancellationToken)
	{
		var products = await repository.ListAsync(cancellationToken);

		return new ListProductsResponse(products.Select(p => p.ToDto()).ToList());
	}
}
