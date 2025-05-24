using MediatR;

namespace ReStoreEcommerce.Application.ProductsManagement.RemoveProduct;

public sealed record RemoveProductRequest(int Id) : IRequest<RemoveProductResponse>;