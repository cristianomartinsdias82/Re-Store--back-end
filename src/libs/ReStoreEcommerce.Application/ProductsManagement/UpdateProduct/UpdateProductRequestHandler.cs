using MediatR;
using ReStoreEcommerce.Application.Common;
using ReStoreEcommerce.Domain.Contracts;
using ReStoreEcommerce.Shared.Persistence;

namespace ReStoreEcommerce.Application.ProductsManagement.UpdateProduct;

internal sealed class UpdateProductRequestHandler(
	IProductRepository repository,
	IUnitOfWork unitOfWork) : IRequestHandler<UpdateProductRequest, UpdateProductResponse>
{
	public async Task<UpdateProductResponse> Handle(
		UpdateProductRequest request,
		CancellationToken cancellationToken)
	{
		var existingProduct = await repository.GetByIdAsync(request.Product.Id!.Value, cancellationToken);
		if (existingProduct is null)
			return new UpdateProductResponse(default!);

		existingProduct
			.SetName(request.Product.Name)
			.SetSku(request.Product.Sku)
			.SetDescription(request.Product.Description)
			.SetPrice(request.Product.Price)
			.SetQuantityInStock(request.Product.QuantityInStock)
			.SetPictureUrl(request.Product.PictureUrl)
			.SetBrand(request.Product.Brand)
			.SetType(request.Product.Type);

		await repository.UpdateAsync(existingProduct, cancellationToken);
		var rowsAffected = await unitOfWork.CommitAsync(cancellationToken);

		return new UpdateProductResponse(rowsAffected > 0 ? existingProduct.ToDto() : default!);
	}
}
