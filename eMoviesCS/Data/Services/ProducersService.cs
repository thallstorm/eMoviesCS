using eMoviesCS.Data.Base;
using eMoviesCS.Models;

namespace eMoviesCS.Data.Services
{
	public class ProducersService:EntityBaseRepository<Producer>, IProducersService
	{
        public ProducersService(AppDbContext context) : base(context)
        {
            
        }
    }
}
