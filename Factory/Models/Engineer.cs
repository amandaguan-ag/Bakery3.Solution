using System.Collections.Generic;

namespace Factory.Models
{
    public class Engineer
    {
        public int EngineerId { get; set; }
        public string Title { get; set; }
        public List<MachineEngineer> JoinEntities { get; }
    }
}