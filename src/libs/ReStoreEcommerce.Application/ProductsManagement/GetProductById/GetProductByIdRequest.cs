using MediatR;

namespace ReStoreEcommerce.Application.ProductsManagement.GetProductById;

public sealed record GetProductByIdRequest(int Id) : IRequest<GetProductByIdResponse>;