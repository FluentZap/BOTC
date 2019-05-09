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
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
          User user = IdCheck.Check(HttpContext.Session.Id);
          if (user == null) return RedirectToAction("Index", "User", new {errorcode = 1});
          List<ItemStats> items = DB.GetAllItemStats();
          return View(items);
        }

        public IActionResult New()
        {
          User user = IdCheck.Check(HttpContext.Session.Id);
          if (user == null) return RedirectToAction("Index", "User", new {errorcode = 1});
          return View();
        }

        public IActionResult Create(string type, string itemName, string speed, string damageDie, string damageType, string attackRange)
        {
          User user = IdCheck.Check(HttpContext.Session.Id);
          if (user == null) return RedirectToAction("Index", "User", new {errorcode = 1});
          ItemStats item = new ItemStats();
          item.Type = type;
          item.Name = itemName;
          item.Speed = int.Parse(speed);
          item.DamageDie = int.Parse(damageDie);
          item.DamageType = damageType;
          item.AttackRange = int.Parse(attackRange);

          string id = DB.CreateItem(item);
          return RedirectToAction("Show", new { id = id });
        }

        [HttpGet("/item/show/{id}")]
        public IActionResult Show(string id)
        {
          User user = IdCheck.Check(HttpContext.Session.Id);
          if (user == null) return RedirectToAction("Index", "User", new {errorcode = 1});
          return View(DB.GetItemStats(id));
        }

        public IActionResult Destroy(string itemId)
        {
          User user = IdCheck.Check(HttpContext.Session.Id);
          if (user == null) return RedirectToAction("Index", "User", new {errorcode = 1});
          DB.DeleteItem(itemId);
          return RedirectToAction("Index");
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
