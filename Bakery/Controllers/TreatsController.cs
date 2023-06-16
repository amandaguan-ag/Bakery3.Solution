using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Controllers
{
    public class TreatsController : Controller
    {
        private readonly BakeryContext _db;

        public TreatsController(BakeryContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Treat> model = _db.Treats.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Treat Treat)
        {
            if (!ModelState.IsValid)
            {
                return View(Treat);
            }
            else
            {
                _db.Treats.Add(Treat);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public ActionResult Details(int id)
        {
            Treat thisTreat = _db.Treats
                .Include(Treat => Treat.JoinEntities)
                .ThenInclude(join => join.Flavor)
                .FirstOrDefault(Treat => Treat.TreatId == id);
            return View(thisTreat);
        }

        public ActionResult Edit(int id)
        {
            Treat thisTreat = _db.Treats.FirstOrDefault(Treat => Treat.TreatId == id);
            return View(thisTreat);
        }

        [HttpPost]
        public ActionResult Edit(Treat Treat)
        {
            _db.Treats.Update(Treat);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Treat thisTreat = _db.Treats.FirstOrDefault(Treat => Treat.TreatId == id);
            return View(thisTreat);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Treat thisTreat = _db.Treats.FirstOrDefault(Treat => Treat.TreatId == id);
            _db.Treats.Remove(thisTreat);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AddFlavor(int id)
        {
            Treat thisTreat = _db.Treats.FirstOrDefault(Treats => Treats.TreatId == id);
            ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Title");
            return View(thisTreat);
        }

        [HttpPost]
        public ActionResult AddFlavor(Treat Treat, int FlavorId)
        {
#nullable enable
            TreatFlavor? joinEntity = _db.TreatFlavors.FirstOrDefault(join => (join.FlavorId == FlavorId && join.TreatId == Treat.TreatId));
#nullable disable
            if (joinEntity == null && FlavorId != 0)
            {
                _db.TreatFlavors.Add(new TreatFlavor() { FlavorId = FlavorId, TreatId = Treat.TreatId });
                _db.SaveChanges();
            }
            return RedirectToAction("Details", new { id = Treat.TreatId });
        }

        [HttpPost]
        public ActionResult DeleteJoin(int joinId)
        {
            TreatFlavor joinEntry = _db.TreatFlavors.FirstOrDefault(entry => entry.TreatFlavorId == joinId);
            _db.TreatFlavors.Remove(joinEntry);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}