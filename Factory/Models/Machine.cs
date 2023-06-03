using System.Collections.Generic;

namespace Factory.Models
{
    public class Machine
    {
        public string Description { get; set; }
        public int Id { get; }
        private static List<Machine> _instances = new List<Machine> { };

        public Machine(string description)
        {
            Description = description;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Machine> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
        public static Machine Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }
}