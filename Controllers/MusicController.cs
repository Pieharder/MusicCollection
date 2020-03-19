using Microsoft.AspNetCore.Mvc;
using RestaurantTown.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MusicCollection.Controllers
{
  public class MusicController : Controller
  {
    private readonly MusicCollectionContext _db;

    public CollectionsController(CollectionTownContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Collection> model = _db.Collections.Include(collections => collections.Type).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.TypeId = new SelectList(_db.Types, "TypeId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Collection collection)
    {
      _db.Collections.Add(collection);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Collection thisCollection = _db.Collections.FirstOrDefault(collections => collections.CollectionId == id);
      return View(thisCollection);
    }

    public ActionResult Edit(int id)
    {
      var thisCollection = _db.Collections.FirstOrDefault(collections => collections.CollectionId == id);
      ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Name");
      return View(thisResturant);
    }

    [HttpPost]
    public ActionResult Edit(Collection collection)
    {
      _db.Entry(collection).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisCollection = _db.Collections.FirstOrDefault(collections => collections.CollectionId == id);
      return View(thisResturant);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisCollection = _db.Collection.FirstOrDefault(collections => collections.CollectionId == id);
      _db.Collections.Remove(thisCollection);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}