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
        // public IActionResult Index()
        // {
        //   User user = IdCheck.Check(HttpContext.Session.Id);
        //   if (user == null) return RedirectToAction("Index", "User", new {errorcode = 1});
        //
        //   List<Bandit> bandits = DB.GetAll();
        //   return View(bandits);
        // }
        //
        // public IActionResult New()
        // {
        //   // User user = IdCheck.Check(HttpContext.Session.Id);
        //   // if (user == null) return RedirectToAction("Index", "User", new {errorcode = 1});
        //   return View("New");
        // }
        //
        // public IActionResult Create(string banditName, string banditClass)
        // {
        //   // User user = IdCheck.Check(HttpContext.Session.Id);
        //   // if (user == null) return RedirectToAction("Index", "User", new {errorcode = 1});
        //   // string id = DB.CreateBandit(banditName, int.Parse(banditClass));
        //   // return RedirectToAction("Show", new { id = id });
        //   //
        //
        //
        //   // using (var db = new BOTCContext())
        //   // {
        //   //     var bandit = new Bandit {Name = banditName, Password = password,
        //   //       SessionId = HttpContext.Session.Id, Privileges = ""};
        //   //       db.User.Add(user);
        //   //       db.SaveChanges();
        //          return RedirectToAction("Index", "Bandit");
        //   //
        // }
        //
        // [HttpGet("/Bandit/show/{id}")]
        // public IActionResult Show(string id)
        // {
        //   User user = IdCheck.Check(HttpContext.Session.Id);
        //   if (user == null) return RedirectToAction("Index", "User", new {errorcode = 1});
        //   return View(DB.GetBandit(id));
        // }
        //
        // // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // // public IActionResult Error()
        // // {
        // //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // // }
    }
}
