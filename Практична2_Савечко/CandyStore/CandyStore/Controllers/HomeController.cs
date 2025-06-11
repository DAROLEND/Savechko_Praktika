using System;
using System.Linq;
using System.Web.Mvc;
using CandyStore.Models;

namespace CandyStore.Controllers
{
    public class HomeController : Controller
    {
        SweetContext db = new SweetContext();

        public ActionResult Index()
        {
            ViewBag.Sweets = db.Sweets.ToList();
            return View();
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
    }
}
