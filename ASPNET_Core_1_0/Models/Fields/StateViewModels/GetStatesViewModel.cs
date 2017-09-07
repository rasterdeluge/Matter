using MatterCentral.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatterCentral.Models
{
    public class GetStatesViewModel
    {
        public List<KeyValuePair<string, int>> States { get; set; }

        // Only used to generate the select dropdowns and labels in the view
        public State State;

        public GetStatesViewModel(List<State> States)
        {
            this.States = new List<KeyValuePair<string, int>>();
            foreach (var State in States) {
                this.States.Add(new KeyValuePair<string, int>(State.Name, State.Id));
            }
        }
    }
}
