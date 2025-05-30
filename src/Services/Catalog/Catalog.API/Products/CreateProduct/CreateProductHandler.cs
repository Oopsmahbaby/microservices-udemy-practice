using MediatR;

namespace Catalog.API.Products.CreateProduct
{
	public record CreateProductCommand(
		string Name,
		List<string> Category,
		string Description,
		decimal Price,
		string ImageFile) : IRequest<CreateProductResult>;

	public record CreateProductResult(
		Guid Id,
		string Name,
		List<string> Category,
		string Description,
		decimal Price,
		string ImageFile);

	internal class CreateProductHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
	{
		public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
