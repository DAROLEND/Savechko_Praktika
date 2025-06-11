using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CandyStore.Models
{
    public class Sale
    {
        public int SaleId { get; set; }       
        public string CustomerName { get; set; }
        public string Address { get; set; }     
        public int SweetId { get; set; }        
        public DateTime Date { get; set; }      
    }
}