
using Microsoft.AspNetCore.Mvc;
using TamagotchiProject.Models;
using System.Collections.Generic;

namespace TamagotchiProject.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpPost("/")]
      public ActionResult Create(string tamaName)
      {
      Tamagotchi newTama = new Tamagotchi(tamaName);
      List<Tamagotchi> allItems = Tamagotchi.GetAll();
      return View(allItems);
      }

    }
}