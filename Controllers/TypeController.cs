using Microsoft.AspNetCore.Mvc;
using MusicCollection.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MusicCollection.Controllers
{
    public class TypesController : Controller
    {
        private readonly MusicCollectionContect _db;

        public TypesController(MusicCollectionContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Type> model = _db.Types.ToList();
            return View(models);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Type Type)
        {
            _db.Types.Add(type);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Type thisType = _db.Types.FirstOrDefault(type => type.TypeId == id);
            thisType.Collections = _db.Collections.Where(collection => collection.MusicId == id).ToList();
            return View(thisType);
        }

        public ActionResult Edit(int id)
        {
            var thisType = _db.Types.FirstOrDefault(type => type.TypeId == id);
            return View(thisType);
        }

        [HttpPost]
        public ActionResult Edit(Type type)
        {
            _db.Entry(type).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var thisType = _db.Types.FirstOrDefault(type => type.TypeId == id);
            return View(thisType); 
        }
    }
}

