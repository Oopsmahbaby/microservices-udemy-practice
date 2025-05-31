using BuildingBlocks.CQRS;
using Catalog.API.Models;

namespace Catalog.API.Products.CreateProduct
{
	public record CreateProductCommand(
		string Name,
		List<string> Category,
		string Description,
		decimal Price,
		string ImageFile) : ICommand<CreateProductResult>;

	public record CreateProductResult(
		Guid Id,
		string Name,
		List<string> Category,
		string Description,
		decimal Price,
		string ImageFile);

	internal class CreateProductHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
	{
		/// <summary>
		/// Create Prduct entity from command object and return the result.
		/// </summary>
		/// <param name="command"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
		{
			// Here you would typically interact with a database or another service to create the product.
			var productId = Guid.NewGuid(); // Simulating product creation and getting an ID
			var result = new Product
			{
				Id = productId,
				Name = command.Name,
				Category = command.Category,
				Description = command.Description,
				Price = command.Price,
				ImageFile = command.ImageFile
			};

			// Return the result as CreateProductResult
			var createProductResult = new CreateProductResult(
				result.Id,
				result.Name,
				result.Category,
				result.Description,
				result.Price,
				result.ImageFile);

			return Task.FromResult(createProductResult);
		}
	}
}
