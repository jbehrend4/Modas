﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modas.Models
{
    public class ViewEvents
    {
        public IEnumerable<Event> Events { get; set; }
        public Pages Pages { get; set; }
    }
}
