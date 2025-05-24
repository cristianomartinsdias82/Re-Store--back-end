using ReStoreEcommerce.Application.Common;

namespace ReStoreEcommerce.Application.ProductsManagement.ListProducts;

public sealed record ListProductsResponse(IList<ProductDto> Products);