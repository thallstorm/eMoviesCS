﻿using eMoviesCS.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eMoviesCS.Controllers
{
	public class MoviesController : Controller
	{
		private readonly AppDbContext _context;

		public MoviesController(AppDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			var allCinemas = await _context.Movies.ToListAsync();
			return View();
		}
	}
}
