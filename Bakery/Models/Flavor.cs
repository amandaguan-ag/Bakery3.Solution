using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
    public class Flavor
    {
        public int FlavorId { get; set; }
        [Required(ErrorMessage = "The Flavor's title can't be empty!")]
        public string Title { get; set; }
        public List<TreatFlavor> JoinEntities { get; }
    }
}