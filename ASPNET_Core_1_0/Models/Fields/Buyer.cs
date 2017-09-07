using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatterCentral.Models
{
    public class Buyer
    {
        public int Id { get; set; }
        public bool ItemStatus { get; set; }
        public string Alias { get; set; }
        public string OrganizationalUnit { get; set; }
    }
}
