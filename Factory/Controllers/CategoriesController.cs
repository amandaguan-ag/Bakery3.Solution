// using System.Collections.Generic;
// using System;
// using Microsoft.AspNetCore.Mvc;
// using Factory.Models;

// namespace Factory.Controllers
// {
//     public class CategoriesController : Controller
//     {

//         [HttpGet("/categories")]
//         public ActionResult Index()
//         {
//             List<Category> allCategories = Category.GetAll();
//             return View(allCategories);
//         }

//         [HttpGet("/categories/new")]
//         public ActionResult New()
//         {
//             return View();
//         }

//         [HttpPost("/categories")]
//         public ActionResult Create(string categoryName)
//         {
//             Category newCategory = new Category(categoryName);
//             return RedirectToAction("Index");
//         }

//         [HttpGet("/categories/{id}")]
//         public ActionResult Show(int id)
//         {
//             Dictionary<string, object> model = new Dictionary<string, object>();
//             Category selectedCategory = Category.Find(id);
//             List<Machine> categoryMachines = selectedCategory.Machines;
//             model.Add("category", selectedCategory);
//             model.Add("machines", categoryMachines);
//             return View(model);
//         }


//         // This one creates new Machines within a given Category, not new Categories:

//         [HttpPost("/categories/{categoryId}/machines")]
//         public ActionResult Create(int categoryId, string machineDescription)
//         {
//             Dictionary<string, object> model = new Dictionary<string, object>();
//             Category foundCategory = Category.Find(categoryId);
//             Machine newMachine = new Machine(machineDescription);
//             foundCategory.AddMachine(newMachine);
//             List<Machine> categoryMachines = foundCategory.Machines;
//             model.Add("machines", categoryMachines);
//             model.Add("category", foundCategory);
//             return View("Show", model);
//         }

//     }
// }