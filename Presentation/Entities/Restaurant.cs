﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;

namespace Presentation.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public Restaurant(string name, string description, bool status= true) 
        { 
            Name = name;
            Description = description;
            Status = status;       
        }

    }
}
