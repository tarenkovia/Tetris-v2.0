﻿using Entities;
using LessonApplication.Models;
using LessonApplication.Models.Games;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;
using BL;

namespace LessonApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IUsersBL _userBL;
        private IGamesBL _gamesBL;

        public HomeController(ILogger<HomeController> logger, IUsersBL usersBL, IGamesBL gamesBL)
        {
            _logger = logger;
            _userBL = usersBL;
            _gamesBL = gamesBL;
        }

        [Authorize]
        public IActionResult Index(int id, string name)
        {
            TempData["Success"] = "Success";

            if (User.Identity.IsAuthenticated) 
            {
                var userName = User.Identity.Name;
            } 

            return View("Index");
        }

        public IActionResult Privacy()
        {
			return View();
		}


        public IActionResult Info() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        [Authorize]
        public IActionResult OpenTetris()
        {
            Game game = new Game();
            GameModel gameModel = new GameModel()
            {
                Score = 0,
                UserId = _userBL.GetByLogin(User.Identity.Name).Id
            };
            return View(gameModel);
        }

		[HttpPost]
		[Authorize]
		public IActionResult SaveTetris(int score)
		{
			Game game = new Game()
			{
				Score = score,
				UserId = _userBL.GetByLogin(User.Identity.Name).Id
			};

			_gamesBL.WriteGameToBD(game);

            return RedirectToAction("Index", "Home");
		}
	}
}
