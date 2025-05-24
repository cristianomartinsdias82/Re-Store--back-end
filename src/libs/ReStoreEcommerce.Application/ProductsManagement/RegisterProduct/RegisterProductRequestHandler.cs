using MediatR;
using ReStoreEcommerce.Application.Common;
using ReStoreEcommerce.Domain.Contracts;
using ReStoreEcommerce.Domain.Entities;
using ReStoreEcommerce.Shared.Persistence;

namespace ReStoreEcommerce.Application.ProductsManagement.RegisterProduct;

internal sealed class RegisterProductRequestHandler(
	IProductRepository repository,
	IUnitOfWork unitOfWork) : IRequestHandler<RegisterProductRequest, RegisterProductResponse>
{
	public async Task<RegisterProductResponse> Handle(
		RegisterProductRequest request,
		CancellationToken cancellationToken)
	{
		var newProduct = Product.Create(
			request.Product.Sku,
			request.Product.Name,
			request.Product.Description,
			request.Product.PictureUrl,
			request.Product.Type,
			request.Product.Brand,
			request.Product.Price,
			request.Product.QuantityInStock);

		await repository.InsertAsync(newProduct, cancellationToken);
		var rowsAffected = await unitOfWork.CommitAsync(cancellationToken);

		return new RegisterProductResponse(rowsAffected > 0 ? newProduct.ToDto() : default!);
	}
}
