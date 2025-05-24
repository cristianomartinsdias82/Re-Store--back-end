using MediatR;
using ReStoreEcommerce.Domain.Contracts;
using ReStoreEcommerce.Shared.Persistence;

namespace ReStoreEcommerce.Application.ProductsManagement.RemoveProduct;

internal sealed class RemoveProductRequestHandler(
	IProductRepository repository,
	IUnitOfWork unitOfWork) : IRequestHandler<RemoveProductRequest, RemoveProductResponse>
{
	public async Task<RemoveProductResponse> Handle(
		RemoveProductRequest request,
		CancellationToken cancellationToken)
	{
		if (!await repository.ExistsAsync(x => x.Id == request.Id, cancellationToken))
			return new RemoveProductResponse(false);

		await repository.RemoveAsync(request.Id, cancellationToken);
		var rowsAffected = await unitOfWork.CommitAsync(cancellationToken);

		return new RemoveProductResponse(rowsAffected > 0);
	}
}
