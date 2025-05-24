using MediatR;
using ReStoreEcommerce.Application.Common;
using ReStoreEcommerce.Domain.Contracts;

namespace ReStoreEcommerce.Application.ProductsManagement.GetProductById;

internal sealed class GetProductByIdRequestHandler(IProductRepository repository) : IRequestHandler<GetProductByIdRequest, GetProductByIdResponse>
{
	public async Task<GetProductByIdResponse> Handle(
		GetProductByIdRequest request,
		CancellationToken cancellationToken)
	{
		var product = await repository.GetByIdAsync(request.Id, cancellationToken);

		return new GetProductByIdResponse(product?.ToDto());
	}
}
