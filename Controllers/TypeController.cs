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
    }
}