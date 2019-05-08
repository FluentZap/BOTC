using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BanditsOfTheCoast.Solution.Models;
using BOTC;

namespace BanditsOfTheCoast.Solution.Controllers
{
    public class BanditController : Controller
    {
        public IActionResult Index()
        {
          List<Bandit> bandits = DB.GetAll();
          return View(bandits);
        }

        public IActionResult New()
        {
            return View();
        }

        public IActionResult Create(string banditName, string banditClass)
        {
          string id = DB.CreateBandit(banditName, int.Parse(banditClass));
          return RedirectToAction("Show", new { id = id });
        }

        [HttpGet("/Bandit/show/{id}")]
        public IActionResult Show(string id)
        {

          return View();
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
