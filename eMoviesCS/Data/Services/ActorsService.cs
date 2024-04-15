using eMoviesCS.Data.Base;
using eMoviesCS.Models;
using Microsoft.EntityFrameworkCore;

namespace eMoviesCS.Data.Services
{
	public class ActorsService : EntityBaseRepository<Actor>, IActorsService
	{	
		public ActorsService(AppDbContext context) : base(context) { }
	}
}
