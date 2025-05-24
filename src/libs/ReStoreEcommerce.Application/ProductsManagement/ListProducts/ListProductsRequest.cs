using MediatR;

namespace ReStoreEcommerce.Application.ProductsManagement.ListProducts;

public sealed record ListProductsRequest() : IRequest<ListProductsResponse>;