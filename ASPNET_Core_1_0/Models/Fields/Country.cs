using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatterCentral.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public ISet<State> States { get; protected set; }
    }
}
