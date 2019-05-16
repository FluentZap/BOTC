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
          User user = IdCheck.Check(HttpContext.Session.Id);
          if (user == null) return RedirectToAction("Index", "User", new {errorcode = 1});

          List<Bandit> bandits = DB.GetAll(HttpContext.Session.Id);
          ViewBag.UserTitle = user.UserName;
          return View(bandits);
        }

        public IActionResult New()
        {
          ViewBag.Classes = DB.GetAllClasses();
          User user = IdCheck.Check(HttpContext.Session.Id);
          if (user == null) return RedirectToAction("Index", "User", new {errorcode = 1});
          ViewBag.UserTitle = user.UserName;
          return View("New");
        }

        public IActionResult Create(string banditName, string banditClass)
        {
          User user = IdCheck.Check(HttpContext.Session.Id);
          if (user == null) return RedirectToAction("Index", "User", new {errorcode = 1});
          string id = DB.CreateBandit(banditName, HttpContext.Session.Id, int.Parse(banditClass));
          ViewBag.UserTitle = user.UserName;
          return RedirectToAction("Show", new { id = id });
        }

        [HttpGet("/Bandit/show/{id}")]
        public IActionResult Show(string id)
        {
          User user = IdCheck.Check(HttpContext.Session.Id);
          if (user == null) return RedirectToAction("Index", "User", new {errorcode = 1});
          ViewBag.UserTitle = user.UserName;
          return View(DB.GetBandit(id));
        }

    }
}
