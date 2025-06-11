using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CandyStore.Models
{
    public class SweetFilterViewModel
    {
        public IEnumerable<Sweet> Sweets { get; set; }
        public SelectList Manufacturers { get; set; }
        public string SelectedManufacturer { get; set; }
        public string NameSearch { get; set; }
    }
}
