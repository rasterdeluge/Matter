using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MatterCentral.Models
{
    public class Authorization
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Buyer { get; set; }
        public DateTime Effective { get; set; }
        public DateTime Expiration { get; set; }
        
        public ISet<Commodity> Commodities { get; protected set; }
        
        public int? AccountId { get; set; }
        public Account Account { get; set; }

        public int? StatusId { get; set; }
        public AuthorizationStatus Status { get; set; }

        public int? ShipperId { get; set; }
        public Organization Shipper { get; set; }

        public int? ReceiverId { get; set; }
        public Organization Receiver { get; set; }
    }
}
