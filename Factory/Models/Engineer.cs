using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Engineer
    {
        public int EngineerId { get; set; }
        [Required(ErrorMessage = "The engineer's title can't be empty!")]
        public string Title { get; set; }
        public List<MachineEngineer> JoinEntities { get; }
    }
}