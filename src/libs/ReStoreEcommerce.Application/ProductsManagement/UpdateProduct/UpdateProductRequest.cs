using MediatR;
using ReStoreEcommerce.Application.Common;

namespace ReStoreEcommerce.Application.ProductsManagement.UpdateProduct;

public sealed record UpdateProductRequest(ProductDto Product) : IRequest<UpdateProductResponse>;