using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReStoreEcommerce.Application.Common;
using ReStoreEcommerce.Application.ProductsManagement.GetProductById;
using ReStoreEcommerce.Application.ProductsManagement.ListProducts;
using ReStoreEcommerce.Application.ProductsManagement.RegisterProduct;
using ReStoreEcommerce.Application.ProductsManagement.RemoveProduct;
using ReStoreEcommerce.Application.ProductsManagement.UpdateProduct;

namespace ReStoreEcommerceApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController(ISender sender) : ControllerBase
{
	[HttpGet(Name = "GetProducts")]
	public async Task<IActionResult> Get(CancellationToken cancellationToken)
	{
		var response = await sender.Send(new ListProductsRequest(), cancellationToken);

		return Ok(response.Products);
	}

	[HttpGet("{id}", Name = "GetProductById")]
	public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
	{
		var response = await sender.Send(new GetProductByIdRequest(id), cancellationToken);

		if (response.Product is null)
			return NotFound();

		return Ok(response.Product);
	}

	[HttpPost(Name = "PostProduct")]
	public async Task<IActionResult> Post(ProductDto product, CancellationToken cancellationToken)
	{
		var response = await sender.Send(new RegisterProductRequest(product), cancellationToken);

		if ((response.Product?.Id ?? 0) > 0)
			return CreatedAtRoute("GetProductById", new { id = response.Product!.Id }, response.Product);

		return Problem();
	}

	[HttpPut(Name = "PutProduct")]
	public async Task<IActionResult> Put(ProductDto product, CancellationToken cancellationToken)
	{
		var response = await sender.Send(new UpdateProductRequest(product), cancellationToken);

		if (response.Product is not null)
			return Ok(response.Product);

		return Problem();
	}

	[HttpDelete("{id}", Name = "DeleteProduct")]
	public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
	{
		await sender.Send(new RemoveProductRequest(id), cancellationToken);

		return NoContent();
	}
}
