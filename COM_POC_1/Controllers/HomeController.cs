using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using COM_POC_1.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using COM_POC_1.Models;

namespace COM_POC_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICoMRepository _repository;

        public HomeController(ICoMRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            ViewBag.title = "City of Mists";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet("Characters")]
        public IActionResult CharacterDetails()
        {
            return View();
        }
        [HttpPost("Characters")]
        public IActionResult CharacterDetails(Character character)
        {
            return View();
        }

        public IActionResult Games()
        {
            var games = _repository.GetAllGames();
            return View(games);
        }
    }
}
