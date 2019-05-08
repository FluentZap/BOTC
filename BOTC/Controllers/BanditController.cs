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

        public IActionResult Create()
        {
          return RedirectToAction("Show");
        }

        public IActionResult Show()
        {

          return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
