using MatterCentral.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatterCentral.Models
{
    public class ListAuthorizationViewModel
    {
        public List<Authorization> Authorizations { get; set; }

        public ListAuthorizationViewModel(List<Authorization> Authorizations)
        {
            this.Authorizations = Authorizations;
        }
    }
}
