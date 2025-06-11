using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CandyStore.Models
{
    public class SweetDbInitializer : DropCreateDatabaseAlways<SweetContext>
    {
        protected override void Seed(SweetContext db)
        {
            db.Sweets.Add(new Sweet { Name = "Шоколад", Manufacturer = "Roshen", Price = 50 });
            db.Sweets.Add(new Sweet { Name = "Карамель", Manufacturer = "Konti", Price = 30 });
            db.Sweets.Add(new Sweet { Name = "Зефір", Manufacturer = "AVK", Price = 40 });
            db.Sweets.Add(new Sweet { Name = "Торт 'Наполеон'", Manufacturer = "Солодкий рай", Price = 150 });

            base.Seed(db);
        }
    }
}
