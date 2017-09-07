using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatterCentral.Models
{
    public class Commodity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int SubGroupId { get; set; }
        public string SubGroupName { get; set; }
        public int DescId { get; set; }
        public string DescName { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
    }
}
