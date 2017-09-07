using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MatterCentral.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ZipCode { get; set; }
        public bool IsActive { get; set; }
        public string ARAccountingCode { get; set; }
        public string APAccountingCode { get; set; }
        public string ExternalAccountingId { get; set; }
        public string TaxId { get; set; }

        public int? TypeId { get; set; }
        public AccountType Type { get; set; }

        public int? CityId { get; set; }
        public City City { get; set; }

        public int? PaymentTermId { get; set; }
        public PaymentTerm PaymentTerm { get; set; }
    }
}
