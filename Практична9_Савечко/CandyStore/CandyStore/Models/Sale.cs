using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CandyStore.Models
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }

        [Required]
        public string CustomerName { get; set; }

        public string Address { get; set; }

        public int SweetId { get; set; }

        public virtual Sweet Sweet { get; set; }

        public DateTime Date { get; set; }
    }
}
