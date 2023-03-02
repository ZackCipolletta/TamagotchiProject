using Microsoft.AspNetCore.Mvc;
using TamagotchiProject.Models;
using System.Collections.Generic;
using System;

namespace TamagotchiProject.Controllers
{
  public class TamagotchiController : Controller
  {

    public ActionResult Index()
    {
      return View();
    }


    public ActionResult Show(int Id)
    {
      Tamagotchi tama = Tamagotchi.FindWithId(Id);
      return View("Index", tama);
    }
    public ActionResult Feed(int Id)
    {
      Tamagotchi tama = Tamagotchi.FindWithId(Id);
      tama.Feed();
      return View("Index", tama);
    }
    public ActionResult GiveAttention(int Id)
    {
      Tamagotchi tama = Tamagotchi.FindWithId(Id);
      tama.GiveAttention();
      return View("Index", tama);
    }
    public ActionResult GiveSleep(int Id)
    {
      Tamagotchi tama = Tamagotchi.FindWithId(Id);
      tama.GiveSleep();
      return View("Index", tama);
    }

    //   [HttpPost("/items")]
    //   public ActionResult Create(string description)
    //   {
    //     Item myItem = new Item(description);
    //     return RedirectToAction("Index");
    //   }

    //   [HttpPost("/items/delete")]
    //   public ActionResult DeleteAll()
    //   {
    //     Item.ClearAll();
    //     return View();
    //   }

    //   [HttpGet("/items/{id}")]
    //   public ActionResult Show(int id)
    //   {
    //     Item foundItem = Item.Find(id);
    //     return View(foundItem);
    //   }
  }
}