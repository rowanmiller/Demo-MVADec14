using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using CycleSales.Models;

namespace CycleSales.Controllers
{
    public class BikeController : Controller
    {
        private CycleSalesContext db;

        public BikeController(CycleSalesContext context)
        {
            db = context;
        }

        public IActionResult DoublePrices()
        {
            foreach (var item in db.Bikes)
            {
                item.Retail *= 2;
            }

            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Bike
        public ViewResult Index()
        {
            return View(db.Bikes.ToList());
        }

        // GET: Bike/Details/5
        public IActionResult Details(System.Int32? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(404);
            }

            Bike bike = db.Bikes.Single(m => m.BikeId == id);
            if (bike == null)
            {
                return new HttpStatusCodeResult(404);
            }

            return View(bike);
        }

        // GET: Bike/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bike/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Bike bike)
        {
            if (ModelState.IsValid)
            {
                db.Bikes.Add(bike);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bike);
        }

        // GET: Bike/Edit/5
        public IActionResult Edit(System.Int32? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(404);
            }

            Bike bike = db.Bikes.Single(m => m.BikeId == id);
            if (bike == null)
            {
                return new HttpStatusCodeResult(404);
            }

            return View(bike);
        }

        // POST: Bike/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Bike bike)
        {
            if (ModelState.IsValid)
            {
                db.Bikes.Update(bike);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bike);
        }

        // GET: Bike/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(System.Int32? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(404);
            }

            Bike bike = db.Bikes.Single(m => m.BikeId == id);
            if (bike == null)
            {
                return new HttpStatusCodeResult(404);
            }

            return View(bike);
        }

        // POST: Bike/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(System.Int32 id)
        {
            Bike bike = db.Bikes.Single(m => m.BikeId == id);
            db.Bikes.Remove(bike);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
