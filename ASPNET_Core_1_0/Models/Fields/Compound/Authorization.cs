using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_Core_1_0.Models
{
    public class Authorization
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int ShipperId { get; set; }
        public int ReceiverId { get; set; }
        public int ReceiverContactId { get; set; }
        public int CountyId { get; set; }
        public int SupplierId { get; set; }
        public int ReceiveLocationId { get; set; }

        public Authorization()
        {
        }

        public Authorization(int Id, string Number, int ShipperId, int ReceiverId, int ReceiverContactId, int CountyId, int SupplierId, int ReceiveLocationId)
        {
            this.Id = Id;
            this.Number = Number;
            this.ShipperId = ShipperId;
            this.ReceiverId = ReceiverId;
            this.ReceiverContactId = ReceiverContactId;
            this.CountyId = CountyId;
            this.SupplierId = SupplierId;
            this.ReceiveLocationId = ReceiveLocationId;
        }
    }
}
