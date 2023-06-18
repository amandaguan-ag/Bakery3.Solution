using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Bakery.Controllers
{
    public class HomeController : Controller
    {
        private readonly BakeryContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(UserManager<ApplicationUser> userManager, BakeryContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        [HttpGet("/")]
        public async Task<ActionResult> Index()
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ApplicationUser currentUser = null;

            if (userId != null)
            {
                currentUser = await _userManager.FindByIdAsync(userId);
            }

            if (currentUser == null)
            {
                model.Add("flavors", _db.Flavors.ToArray());
                model.Add("treats", null);
            }
            else
            {
                model.Add("flavors", _db.Flavors.ToArray());
                model.Add("treats", _db.Treats.Where(treat => treat.User.Id == currentUser.Id).ToArray());
            }

            return View(model);
        }
    }
}
