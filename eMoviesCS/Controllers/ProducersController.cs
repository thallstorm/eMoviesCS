﻿using eMoviesCS.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eMoviesCS.Controllers
{
	public class ProducersController : Controller
	{
		private readonly AppDbContext _context;

		public ProducersController(AppDbContext context)
		{
			_context = context;
		}

		//Async Way
		public async Task<IActionResult> Index()
		{
			var allProducers = await _context.Producers.ToListAsync();
			return View(allProducers);
		}

		//Typical Way

		/*public IActionResult Index()
		{
			var allProducers = _context.Producers.ToList();
			return View();
		}*/
	}
}
