using System.Collections.Generic;

namespace Factory.Models
{
    public class Machine
    {
        public string Description { get; set; }
        private static List<Machine> _instances = new List<Machine> { };

        public Machine(string description)
        {
            Description = description;
            _instances.Add(this);
        }

        public static List<Machine> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}