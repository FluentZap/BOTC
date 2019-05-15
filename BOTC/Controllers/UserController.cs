using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BanditsOfTheCoast.Solution.Models;
using BOTC;

namespace BanditsOfTheCoast.Solution.Controllers
{
  // public static class IdCheck
  // {
  //   public static User Check(string sessionId)
  //   {
  //     if (DB.CheckForUserById(sessionId))
  //     {
  //       return DB.GetUser(sessionId);
  //     }
  //     return null;
  //   }
  // }
  //
  //
  //
  // public class UserController : Controller
  // {
  //
  //   public IActionResult Index(int errorcode)
  //   {
  //     //ISession.SetInt32(HttpContext.Session, "Id", 87098734);
  //     string name = HttpContext.Session.Id;
  //     return View(errorcode);
  //   }
  //
  //   public IActionResult New()
  //   {
  //     return View();
  //   }
  //
  //   public IActionResult Create(string userName, string password)
  //   {
  //     HttpContext.Session.Set("Id", new Byte[0]);
  //     using (var db = new BOTCContext())
  //     {
  //       var getUser = db.User.Where(b => b.UserName == userName).FirstOrDefault();
  //       if (getUser == null)
  //       {
  //         var user = new User {UserName = userName, Password = password,
  //           SessionId = HttpContext.Session.Id, Privileges = ""};
  //           db.User.Add(user);
  //           db.SaveChanges();
  //           return RedirectToAction("Index", "Bandit");
  //       }
  //       else
  //       {
  //         return RedirectToAction("Index", new {errorcode = 2});
  //       }
  //     }
  //   }
  //
  //   public IActionResult Login()
  //   {
  //     HttpContext.Session.Set("Id", new Byte[0]);
  //     return View();
  //   }
  //
  //   public IActionResult Update(string userName, string password)
  //   {
  //     HttpContext.Session.Set("Id", new Byte[0]);
  //     if(DB.CheckForUserByName(userName))
  //     {
  //       User user = DB.GetUserByName(userName);
  //       if(user.Password == password)
  //       {
  //         DB.UpdateUserSessionId(userName, HttpContext.Session.Id);
  //         return RedirectToAction("Index", "Bandit");
  //       }
  //       else
  //       {
  //         return RedirectToAction("Index", new {errorcode = 3});
  //       }
  //     }
  //     return RedirectToAction("Index", new {errorcode = 2});
  //   }
  //
  //   // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  //   // public IActionResult Error()
  //   // {
  //   //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  //   // }
  // }
}
