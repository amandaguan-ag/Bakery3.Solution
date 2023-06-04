// using Microsoft.AspNetCore.Mvc;
// using Factory.Models;
// using System.Collections.Generic;

// namespace Factory.Controllers
// {
//   public class MachinesController : Controller
//   {

//     [HttpGet("/categories/{categoryId}/machines/new")]
//     public ActionResult New(int categoryId)
//     {
//       Category category = Category.Find(categoryId);
//       return View(category);
//     }

//     [HttpPost("/machines/delete")]
//     public ActionResult DeleteAll()
//     {
//       Machine.ClearAll();
//       return View();
//     }

//     [HttpGet("/categories/{categoryId}/machines/{machineId}")]
//     public ActionResult Show(int categoryId, int machineId)
//     {
//       Machine machine = Machine.Find(machineId);
//       Category category = Category.Find(categoryId);
//       Dictionary<string, object> model = new Dictionary<string, object>();
//       model.Add("machine", machine);
//       model.Add("category", category);
//       return View(model);
//     }
//   }
// }