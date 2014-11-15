﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Olimpiadas.Models;

namespace Olimpiadas.Controllers
{
    public class PruebaController : Controller
    {
        private OlimpiadasContainer db = new OlimpiadasContainer();

        //
        // GET: /Prueba/

        public ActionResult Index()
        {
            return View(db.Pruebas.ToList());
        }

        //
        // GET: /Prueba/Details/5

        public ActionResult Details(int id = 0)
        {
            Prueba prueba = db.Pruebas.Find(id);
            if (prueba == null)
            {
                return HttpNotFound();
            }
            return View(prueba);
        }

        //
        // GET: /Prueba/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Prueba/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Prueba prueba)
        {
            if (ModelState.IsValid)
            {
                db.Pruebas.Add(prueba);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(prueba);
        }

        //
        // GET: /Prueba/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Prueba prueba = db.Pruebas.Find(id);
            if (prueba == null)
            {
                return HttpNotFound();
            }
            return View(prueba);
        }

        //
        // POST: /Prueba/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Prueba prueba)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prueba).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prueba);
        }

        //
        // GET: /Prueba/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Prueba prueba = db.Pruebas.Find(id);
            if (prueba == null)
            {
                return HttpNotFound();
            }
            return View(prueba);
        }

        //
        // POST: /Prueba/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Prueba prueba = db.Pruebas.Find(id);
            db.Pruebas.Remove(prueba);
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