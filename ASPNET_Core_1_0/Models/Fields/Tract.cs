using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatterCentral.Models
{
    public class Tract
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string YearPlanted { get; set; }

        // Navigation Properties
        public int? LocationId { get; set; }
        public Location Location { get; set; }
    }
}
