using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_Core_1_0.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Status { get; set; }
        public string Owner { get; set; }
        public string MaxGrossReceive { get; set; }
        public string MaxTareReceive { get; set; }
        public string MinGrossReceive { get; set; }
        public string MinTareReceive { get; set; }
        public string MaxGrossShip { get; set; }
        public string MaxTareShip { get; set; }
        public string MinGrossShip { get; set; }
        public string MinTareShip { get; set; }
    }
}
