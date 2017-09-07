using MatterCentral.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatterCentral.Models
{
    public class CreateAccountViewModel
    {
        public Account Account { get; set; }
        public SelectList AccountTypes { get; set; }
        public SelectList PaymentTerms { get; set; }
        public SelectList Countries { get; set; }

        // Only used to generate the select dropdowns and labels in the view
        public Country Country;
        public State State;

        public CreateAccountViewModel(Account Account, List<AccountType> AccountTypes, List<PaymentTerm> PaymentTerms, List<Country> Countries)
        {
            this.Account = Account;
            this.AccountTypes = new SelectList(AccountTypes, "Id", "Title");
            this.PaymentTerms = new SelectList(PaymentTerms, "Id", "Name");
            this.Countries = new SelectList(Countries, "Id", "Name");
        }
    }
}
