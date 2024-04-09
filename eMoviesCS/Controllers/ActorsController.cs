﻿using eMoviesCS.Data;
using eMoviesCS.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace eMoviesCS.Controllers
{
	public class ActorsController : Controller
	{
		private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
			_service = service;
        }
        public async Task<IActionResult> Index()
		{
			var data = await _service.GetAll();
			return View(data);
		}
	}
}
