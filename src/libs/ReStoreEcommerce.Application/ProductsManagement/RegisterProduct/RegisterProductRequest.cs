using MediatR;
using ReStoreEcommerce.Application.Common;

namespace ReStoreEcommerce.Application.ProductsManagement.RegisterProduct;

public sealed record RegisterProductRequest(ProductDto Product) : IRequest<RegisterProductResponse>;