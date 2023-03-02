
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
        List<Tamagotchi> allItems = Tamagotchi.GetAll();
        return View(allItems);
      }

      [HttpPost("/")]
      public ActionResult Create(string tamagotchiName)
      {
      Tamagotchi newTama = new Tamagotchi(tamagotchiName);
      return RedirectToAction("Index");
      }

      public ActionResult Remove(int Id)
      {
        Tamagotchi tama = Tamagotchi.FindWithId(Id);
        Tamagotchi.GetAll().Remove(tama);
        return RedirectToAction("Index");
      }

    }
}