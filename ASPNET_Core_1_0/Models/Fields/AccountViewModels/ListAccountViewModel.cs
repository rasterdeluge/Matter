using MatterCentral.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatterCentral.Models
{
    public class ListAccountViewModel
    {
        public List<Account> Accounts { get; set; }

        public ListAccountViewModel(List<Account> Accounts)
        {
            this.Accounts = Accounts;
        }
    }
}
