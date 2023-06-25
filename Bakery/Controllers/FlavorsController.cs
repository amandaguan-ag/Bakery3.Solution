using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Bakery.Controllers
{
    [Authorize]
    public class FlavorsController : Controller
    {
        private readonly BakeryContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public FlavorsController(UserManager<ApplicationUser> userManager, BakeryContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public async Task<ActionResult> Index()
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
            List<Flavor> userFlavors = _db.Flavors
                                .Where(entry => entry.User.Id == currentUser.Id)
                                .Include(flavor => flavor.JoinEntities)
                                .ThenInclude(join => join.Treat)
                                .ToList();
            return View(userFlavors);
        }

        public ActionResult Details(int id)
        {
            Flavor thisFlavor = _db.Flavors
                .Include(Flavor => Flavor.JoinEntities)
                .ThenInclude(join => join.Treat)
                .FirstOrDefault(Flavor => Flavor.FlavorId == id);
            return View(thisFlavor);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Flavor flavor)
        {
            if (!ModelState.IsValid)
            {
                return View(flavor);
            }
            else
            {
                string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
                flavor.User = currentUser;
                _db.Flavors.Add(flavor);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }

        public ActionResult AddTreat(int id)
        {
            Flavor thisFlavor = _db.Flavors.FirstOrDefault(Flavors => Flavors.FlavorId == id);
            ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Description");
            return View(thisFlavor);
        }

        [HttpPost]
        public ActionResult AddTreat(Flavor Flavor, int TreatId)
        {
#nullable enable
            TreatFlavor? joinEntity = _db.TreatFlavors.FirstOrDefault(join => (join.TreatId == TreatId && join.FlavorId == Flavor.FlavorId));
#nullable disable
            if (joinEntity == null && TreatId != 0)
            {
                _db.TreatFlavors.Add(new TreatFlavor() { TreatId = TreatId, FlavorId = Flavor.FlavorId });
                _db.SaveChanges();
            }
            return RedirectToAction("Details", new { id = Flavor.FlavorId });
        }

        public ActionResult Edit(int id)
        {
            Flavor thisFlavor = _db.Flavors.FirstOrDefault(Flavors => Flavors.FlavorId == id);
            return View(thisFlavor);
        }

        [HttpPost]
        public ActionResult Edit(Flavor Flavor)
        {
            _db.Flavors.Update(Flavor);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Flavor thisFlavor = _db.Flavors.FirstOrDefault(Flavors => Flavors.FlavorId == id);
            return View(thisFlavor);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Flavor thisFlavor = _db.Flavors.FirstOrDefault(Flavors => Flavors.FlavorId == id);
            _db.Flavors.Remove(thisFlavor);
            _db.SaveChanges();
            return RedirectToAction("Index");
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