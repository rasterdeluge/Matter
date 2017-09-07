using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatterCentral.Models
{
    public class AccountType
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public bool ShowOnAuthorization { get; set; }
    }
}
