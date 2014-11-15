using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Olimpiadas.Models;

namespace Olimpiadas.Controllers
{
    public class DeportistaController : Controller
    {
        private OlimpiadasContainer db = new OlimpiadasContainer();

        //
        // GET: /Deportista/

        public ActionResult Index()
        {
            return View(db.Deportistas.ToList());
        }

        //
        // GET: /Deportista/Details/5

        public ActionResult Details(int id = 0)
        {
            Deportista deportista = db.Deportistas.Find(id);
            if (deportista == null)
            {
                return HttpNotFound();
            }
            return View(deportista);
        }

        //
        // GET: /Deportista/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Deportista/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Deportista deportista)
        {
            if (ModelState.IsValid)
            {
                db.Deportistas.Add(deportista);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(deportista);
        }

        //
        // GET: /Deportista/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Deportista deportista = db.Deportistas.Find(id);
            if (deportista == null)
            {
                return HttpNotFound();
            }
            return View(deportista);
        }

        //
        // POST: /Deportista/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Deportista deportista)
        {
            if (ModelState.IsValid)
            {
                db.Entry(deportista).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(deportista);
        }

        //
        // GET: /Deportista/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Deportista deportista = db.Deportistas.Find(id);
            if (deportista == null)
            {
                return HttpNotFound();
            }
            return View(deportista);
        }

        //
        // POST: /Deportista/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Deportista deportista = db.Deportistas.Find(id);
            db.Deportistas.Remove(deportista);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}