using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatterCentral.Models
{
    public class Transportation
    {
        public int Id { get; set; }
        public int AccountCode { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public bool ItemStatus { get; set; }
    }
}
