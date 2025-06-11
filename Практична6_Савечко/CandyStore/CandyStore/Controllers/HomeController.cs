using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using CandyStore.Models;

namespace CandyStore.Controllers
{
    public class HomeController : Controller
    {
        private SweetContext db = new SweetContext();

        public ActionResult Index(string manufacturer, string name)
        {
            var sweets = db.Sweets.AsQueryable();

            if (!string.IsNullOrEmpty(manufacturer) && manufacturer != "Усі")
            {
                sweets = sweets.Where(s => s.Manufacturer == manufacturer);
            }

            if (!string.IsNullOrEmpty(name))
            {
                sweets = sweets.Where(s => s.Name.Contains(name));
            }
            var manufacturers = db.Sweets
                .Select(s => s.Manufacturer)
                .Distinct()
                .ToList();
            manufacturers.Insert(0, "Усі");

            var model = new SweetFilterViewModel
            {
                Sweets = sweets.ToList(),
                Manufacturers = new SelectList(manufacturers),
                SelectedManufacturer = manufacturer,
                NameSearch = name
            };

            return View(model);
        }


        public ActionResult Details(int id)
        {
            Sweet sweet = db.Sweets.Find(id);
            if (sweet == null)
                return HttpNotFound();
            return View(sweet);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Sweet sweet)
        {
            if (ModelState.IsValid)
            {
                db.Sweets.Add(sweet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sweet);
        }

        public ActionResult Edit(int id)
        {
            Sweet sweet = db.Sweets.Find(id);
            if (sweet == null)
                return HttpNotFound();
            return View(sweet);
        }

        [HttpPost]
        public ActionResult Edit(Sweet sweet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sweet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sweet);
        }

        public ActionResult Delete(int id)
        {
            Sweet sweet = db.Sweets.Find(id);
            if (sweet == null)
                return HttpNotFound();
            return View(sweet);
        }


        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Sweet sweet = db.Sweets.Find(id);
            if (sweet == null)
                return HttpNotFound();

            db.Sweets.Remove(sweet);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.SweetId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Sale sale)
        {
            sale.Date = DateTime.Now;
            db.Sales.Add(sale);
            db.SaveChanges();
            return "Дякуємо, " + sale.CustomerName + ", за покупку!";
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }












    }
}
