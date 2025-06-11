using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CandyStore.Models
{
    public class Sweet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public int Price { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }

        public Sweet()
        {
            Sales = new List<Sale>();
        }
    }
}
