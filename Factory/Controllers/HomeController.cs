using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {

            List<machine> allmachines = machine.GetAll();
            return View(allmachines);
        }

        [HttpGet("/machines/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/machines")]
        public ActionResult Create(string description)
        {
            machine mymachine = new machine(description);
            return RedirectToAction("Index");
        }

    }
}