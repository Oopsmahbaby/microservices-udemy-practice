namespace Catalog.API.Products.CreateProduct
{
	public record CreateProductRequest(
		string Name,
		List<string> Category,
		string Description,
		decimal Price,
		string ImageFile);

	public record CreateProductResponse(
		Guid Id,
		string Name,
		List<string> Category,
		string Description,
		decimal Price,
		string ImageFile);

	public class CreateProductEndpoint
	{
	}
}
