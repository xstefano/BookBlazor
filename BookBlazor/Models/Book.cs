using System.ComponentModel.DataAnnotations;

namespace BookBlazor.Models
{
	public class Book
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string? Title { get; set; }
		[Required]
		public string? Description { get; set; }
		[Required]
		public string? Author { get; set; }
		[Required]
		public int Pages { get; set; }
		[Required]
		public int Price { get; set; }
		[Required]
		public DateTime ReleaseDate { get; set; }
	}
}
