using System.ComponentModel.DataAnnotations;

namespace eMoviesCS.Models
{
	public class Producer
	{
		[Key]
		public int Id { get; set; }
		public string? ProfilePictureURL { get; set; }

		public required string FullName { get; set; }
		public string? Bio { get; set; }

		//Relationships
		public List<Movie>? Movies { get; set; }
	}
}
