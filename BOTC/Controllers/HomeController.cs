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
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          //ISession.SetInt32(HttpContext.Session, "Id", 87098734);
          Byte[] item = new Byte[7] {0, 2, 7, 3, 9, 9, 6};
          HttpContext.Session.Set("Id", item);
          string name = HttpContext.Session.Id;                      
          return View("Index", name);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
