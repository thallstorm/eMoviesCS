using System.ComponentModel.DataAnnotations;

namespace eMoviesCS.Models
{
	public class Cinema
	{
		[Key]
		public int Id { get; set; }
		public string? Logo { get; set; }
		public required string Name { get; set; }
		public string? Description { get; set; }

		//Relationships
		public List<Movie>? Movies { get; set; }
	}
}
