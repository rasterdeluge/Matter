using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatterCentral.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public bool IsActive { get; set; }
        public string Owner { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public int MaxGrossReceive { get; set; }
        public int MaxTareReceive { get; set; }
        public int MinGrossReceive { get; set; }
        public int MinTareReceive { get; set; }
        public int MaxGrossShip { get; set; }
        public int MaxTareShip { get; set; }
        public int MinGrossShip { get; set; }
        public int MinTareShip { get; set; }
    }
}
