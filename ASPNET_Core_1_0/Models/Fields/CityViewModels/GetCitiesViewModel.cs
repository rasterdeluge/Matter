using MatterCentral.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatterCentral.Models
{
    public class GetCitiesViewModel
    {
        public List<KeyValuePair<string, int>> Cities { get; set; }

        // Only used to generate the select dropdowns and labels in the view
        public City City;

        public GetCitiesViewModel(List<City> Cities)
        {
            this.Cities = new List<KeyValuePair<string, int>>();
            foreach(var City in Cities) {
                this.Cities.Add(new KeyValuePair<string, int>(City.Name, City.Id));
            }
        }
    }
}
