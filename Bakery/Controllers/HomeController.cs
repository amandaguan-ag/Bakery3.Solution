using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Controllers
{
    public class HomeController : Controller
    {
        private readonly BakeryContext _db;

        public HomeController(BakeryContext db)
        {
            _db = db;
        }

        [HttpGet("/")]
        public ActionResult Index()
        {
            Flavor[] Flavors = _db.Flavors.ToArray();
            Treat[] Treats = _db.Treats.ToArray();
            Dictionary<string, object[]> model = new Dictionary<string, object[]>();
            model.Add("flavors", Flavors);
            model.Add("treats", Treats);
            return View(model);
        }
    }
}
