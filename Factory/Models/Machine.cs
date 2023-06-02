using System.Collections.Generic;

namespace Factory.Models
{
    public class machine
    {
        public string Description { get; set; }
        private static List<machine> _instances = new List<machine> { };

        public machine(string description)
        {
            Description = description;
            _instances.Add(this);
        }

        public static List<machine> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}