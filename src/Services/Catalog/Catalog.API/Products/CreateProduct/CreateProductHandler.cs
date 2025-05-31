using BuildingBlocks.CQRS;

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
		public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
