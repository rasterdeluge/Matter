using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatterCentral.Models
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? CountryId { get; set; }
        public Country Country { get; set; }
        
        public ISet<City> Cities { get; protected set; }
    }
}
