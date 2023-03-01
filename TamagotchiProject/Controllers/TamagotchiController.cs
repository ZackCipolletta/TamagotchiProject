using Microsoft.AspNetCore.Mvc;
using TamagotchiProject.Models;
using System.Collections.Generic;
using System;

namespace TamagotchiProject.Controllers
{
  public class TamagotchiController : Controller
  {

    // [HttpGet("/items")]
    // public ActionResult Index()
    // {
    //   List<Item> allItems = Item.GetAll();
    //   return View(allItems);
    // }

    [HttpGet("/show")]
    public ActionResult New()
    {
      return View();
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