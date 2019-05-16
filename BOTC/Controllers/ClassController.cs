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
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
          User user = IdCheck.Check(HttpContext.Session.Id);
          if (user == null) return RedirectToAction("Index", "User", new {errorcode = 1});

          List<Classes> allClasses = DB.GetAllClasses();
          ViewBag.UserTitle = user.UserName;
          return View(allClasses);
        }

        public IActionResult New()
        {
          User user = IdCheck.Check(HttpContext.Session.Id);
          if (user == null) return RedirectToAction("Index", "User", new {errorcode = 1});
          ViewBag.UserTitle = user.UserName;
          return View("New");
        }

        public IActionResult Create(string className, string totalHealth, string currentHealth, string strength, string dexterity)
        {
          User user = IdCheck.Check(HttpContext.Session.Id);
          if (user == null) return RedirectToAction("Index", "User", new {errorcode = 1});
          string id = DB.CreateClass(className, totalHealth, currentHealth, strength, dexterity);;
          ViewBag.UserTitle = user.UserName;
          return RedirectToAction("Show", new { id = id });
        }

        [HttpGet("/class/show/{id}")]
        public IActionResult Show(string id)
        {
          User user = IdCheck.Check(HttpContext.Session.Id);
          if (user == null) return RedirectToAction("Index", "User", new {errorcode = 1});
          ViewBag.UserTitle = user.UserName;
          return View(DB.GetClass(id));
        }
    }
}
