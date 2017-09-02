using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_Core_1_0.Models
{
    public class Account
    {
        public int Id { get; set; }
        public int AuthorizationId { get; set; }
        public string Buyer { get; set; }
        public string Effective { get; set; }
        public string Expiration { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string ContactName { get; set; }
        public string Status { get; set; }

        //public ICollection<T> AccountCollection { get; set; } 
    }
}
