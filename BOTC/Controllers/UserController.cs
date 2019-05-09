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
  public static class IdCheck
  {
    public static User Check(string sessionId)
    {
      if (DB.CheckForUserById(sessionId))
      {
        return DB.GetUser(sessionId);
      }
      return null;
    }
  }



    public class UserController : Controller
    {

        public IActionResult Index()
        {
          //ISession.SetInt32(HttpContext.Session, "Id", 87098734);
          Byte[] item = new Byte[7] {0, 2, 7, 3, 9, 9, 6};
          HttpContext.Session.Set("Id", item);
          string name = HttpContext.Session.Id;
          return View("Index", name);
        }

        public IActionResult New()
        {
            return View();
        }

        public IActionResult Create(string userName, string password)
        {
          if(!DB.CheckForUserByName(userName))
          {
            DB.CreateUser(userName, password, HttpContext.Session.Id, "user");
            return RedirectToAction("Index", "Bandit");
          }
          else
          {
            return RedirectToAction("Index", new {errorcode = 1});
          }
        }

        public IActionResult Login()
        {
          return View();
        }

        public IActionResult Update(string userName, string password)
        {
          if(DB.CheckForUserByName(userName))
          {
            User user = DB.GetUserByName(userName);
            if(user.Password == password)
            {
              DB.UpdateUserSessionId(userName, HttpContext.Session.Id);
              return RedirectToAction("Index", "Bandit");
            }
            else
            {
              return RedirectToAction("Index", new {errorcode = 2});
            }
          }
          return RedirectToAction("Index", new {errorcode = 2});
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
