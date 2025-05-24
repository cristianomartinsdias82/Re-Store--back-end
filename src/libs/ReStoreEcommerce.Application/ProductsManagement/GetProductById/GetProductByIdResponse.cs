using ReStoreEcommerce.Application.Common;

namespace ReStoreEcommerce.Application.ProductsManagement.GetProductById;

public sealed record GetProductByIdResponse(ProductDto? Product);