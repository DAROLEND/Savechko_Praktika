﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CandyStore.Models
{
    public class Sweet
    {
        public int Id { get; set; }           
        public string Name { get; set; }      
        public string Manufacturer { get; set; }
        public int Price { get; set; }        
    }
}
