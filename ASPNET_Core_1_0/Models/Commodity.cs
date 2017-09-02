using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_Core_1_0.Models
{
    public class Commodity
    {
        public int Id { get; set; }
        public string CommodityName { get; set; }
        public string CommodityCode { get; set; }
        public string GroupID { get; set; }
        public string GroupName { get; set; }
        public string SubGroupID { get; set; }
        public string SubGroupName { get; set; }
        public string DescID { get; set; }
        public string DescName { get; set; }
        public string StatusID { get; set; }
        public string StatusName { get; set; }
    }
}
