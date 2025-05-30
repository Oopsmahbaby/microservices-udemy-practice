namespace Catalog.API.Models
{
	public class Product
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = default!;
		public List<string> Category { get; set; } = new();
		public string Description { get; set; } = default!;
		public decimal Price { get; set; }
		public string ImageFile { get; set; } = default!;
		public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
		public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
	}
}
