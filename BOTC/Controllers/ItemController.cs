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
          List<Item> items = DB.GetAllItem();
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
          Item item = new Item();
          Weapon weapon = new Weapon();
          item.Name = itemName;
          item.Type = type;
          item.Cost = 200;

          weapon.Speed = int.Parse(speed);
          weapon.DamageDie = int.Parse(damageDie);
          weapon.DamageType = damageType;
          weapon.AttackRange = int.Parse(attackRange);

          string id = DB.CreateWeapon(item, weapon);
          return RedirectToAction("Show", new { id = id });
        }

        [HttpGet("/item/show/{id}")]
        public IActionResult Show(string id)
        {
          User user = IdCheck.Check(HttpContext.Session.Id);
          if (user == null) return RedirectToAction("Index", "User", new {errorcode = 1});
          ViewBag.Item = DB.GetItem(id);
          ViewBag.ItemStats = DB.GetItemStats(ViewBag.Item.Type_Id.ToString(), ViewBag.Item.Type);
          return View();
        }

        public IActionResult Destroy(string itemId)
        {
          User user = IdCheck.Check(HttpContext.Session.Id);
          if (user == null) return RedirectToAction("Index", "User", new {errorcode = 1});
          DB.DeleteItem(itemId);
          return RedirectToAction("Index");
        }

    }
}
