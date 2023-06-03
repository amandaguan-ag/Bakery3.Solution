using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;

namespace Factory.Controllers
{
    public class MachinesController : Controller
    {

        [HttpGet("/machines")]
        public ActionResult Index()
        {
            List<Machine> allMachines = Machine.GetAll();
            return View(allMachines);
        }

        [HttpGet("/machines/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/machines")]
        public ActionResult Create(string description)
        {
            Machine myMachine = new Machine(description);
            return RedirectToAction("Index");
        }

        [HttpPost("/machines/delete")]
        public ActionResult DeleteAll()
        {
            Machine.ClearAll();
            return View();
        }

        [HttpGet("/machines/{id}")]
        public ActionResult Show(int id)
        {
            Machine foundMachine = Machine.Find(id);
            return View(foundMachine);
        }
    }
}