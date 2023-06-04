// using System.Collections.Generic;

// namespace Factory.Models
// {
//     public class Category
//     {
//         private static List<Category> _instances = new List<Category> { };
//         public string Name { get; set; }
//         public int Id { get; }
//         public List<Machine> Machines { get; set; }

//         public Category(string categoryName)
//         {
//             Name = categoryName;
//             _instances.Add(this);
//             Id = _instances.Count;
//             Machines = new List<Machine> { };
//         }

//         public static void ClearAll()
//         {
//             _instances.Clear();
//         }

//         public static List<Category> GetAll()
//         {
//             return _instances;
//         }

//         public static Category Find(int searchId)
//         {
//             return _instances[searchId - 1];
//         }

//         public void AddMachine(Machine machine)
//         {
//             Machines.Add(machine);
//         }

//     }
// }