﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatterCentral.Models
{
    public class Scaler
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? LocationId { get; set; }
        public Location Location { get; set; }
    }
}
