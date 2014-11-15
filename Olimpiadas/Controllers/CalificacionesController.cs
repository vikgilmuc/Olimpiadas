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
    public class CalificacionesController : Controller
    {
        private OlimpiadasContainer db = new OlimpiadasContainer();

        //
        // GET: /Calificaciones/

        public ActionResult Index()
        {
            return View(db.Calificaciones.ToList());
        }

        //
        // GET: /Calificaciones/Details/5

        public ActionResult Details(int id = 0)
        {
            Calificaciones calificaciones = db.Calificaciones.Find(id);
            if (calificaciones == null)
            {
                return HttpNotFound();
            }
            return View(calificaciones);
        }

        //
        // GET: /Calificaciones/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Calificaciones/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Calificaciones calificaciones)
        {
            if (ModelState.IsValid)
            {
                db.Calificaciones.Add(calificaciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(calificaciones);
        }

        //
        // GET: /Calificaciones/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Calificaciones calificaciones = db.Calificaciones.Find(id);
            if (calificaciones == null)
            {
                return HttpNotFound();
            }
            return View(calificaciones);
        }

        //
        // POST: /Calificaciones/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Calificaciones calificaciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calificaciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(calificaciones);
        }

        //
        // GET: /Calificaciones/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Calificaciones calificaciones = db.Calificaciones.Find(id);
            if (calificaciones == null)
            {
                return HttpNotFound();
            }
            return View(calificaciones);
        }

        //
        // POST: /Calificaciones/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Calificaciones calificaciones = db.Calificaciones.Find(id);
            db.Calificaciones.Remove(calificaciones);
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