using Microsoft.AspNetCore.Mvc;
using Factory.Models;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            Machine starterMachine = new Machine("Add first Machine to To Do List");
            return View(starterMachine);
        }

        [HttpGet("/Machines/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/Machines")]
        public ActionResult Create(string description)
        {
            Machine myMachine = new Machine(description);
            return View("Index", myMachine);
        }

    }
}