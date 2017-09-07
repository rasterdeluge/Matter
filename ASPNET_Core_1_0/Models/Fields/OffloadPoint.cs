using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatterCentral.Models
{
    public class OffloadPoint
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? TractId { get; set; }
        public Tract Tract { get; set; }
    }
}
