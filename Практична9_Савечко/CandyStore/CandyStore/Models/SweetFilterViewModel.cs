using PagedList;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CandyStore.Models
{
    public class SweetFilterViewModel
    {
        public IPagedList<Sweet> Sweets { get; set; } 

        public SelectList Manufacturers { get; set; }
        public string SelectedManufacturer { get; set; }
        public string NameSearch { get; set; }
    }
}
