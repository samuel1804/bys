﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebBS.Models;

namespace WebBS.Controllers
{
    public class PerfilController : Controller
    {
        private BDBoticasEntities db = new BDBoticasEntities();

        // GET: /Perfil/
        public ActionResult Index()
        {
            var perfil = db.Perfil.Include(p => p.Puesto);
            return View(perfil.ToList());
        }

        // GET: /Perfil/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Perfil perfil = db.Perfil.Find(id);
            if (perfil == null)
            {
                return HttpNotFound();
            }
            return View(perfil);
        }

        // GET: /Perfil/Create
        public ActionResult Create()
        {
            ViewBag.IdPuesto = new SelectList(db.Puesto, "IdPuesto", "Nombre");
            return View();
        }

        // POST: /Perfil/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="IdPerfil,IdPuesto,Nombre,Descripcion,Competencias,Caracteristicas,SueldoIni,SueldoFin,Estado")] Perfil perfil)
        {
            if (ModelState.IsValid)
            {
                perfil.IdPerfil = db.Perfil.OrderBy(t => t.IdPerfil).FirstOrDefault().IdPerfil + 1;
                perfil.Estado = 1;
                db.Perfil.Add(perfil);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdPuesto = new SelectList(db.Puesto, "IdPuesto", "Nombre", perfil.IdPuesto);
            return View(perfil);
        }

        // GET: /Perfil/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Perfil perfil = db.Perfil.Find(id);
            if (perfil == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdPuesto = new SelectList(db.Puesto, "IdPuesto", "Nombre", perfil.IdPuesto);
            return View(perfil);
        }

        // POST: /Perfil/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="IdPerfil,IdPuesto,Nombre,Descripcion,Competencias,Caracteristicas,SueldoIni,SueldoFin,Estado")] Perfil perfil)
        {
            if (ModelState.IsValid)
            {
                db.Entry(perfil).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdPuesto = new SelectList(db.Puesto, "IdPuesto", "Nombre", perfil.IdPuesto);
            return View(perfil);
        }

        // GET: /Perfil/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Perfil perfil = db.Perfil.Find(id);
            if (perfil == null)
            {
                return HttpNotFound();
            }
            return View(perfil);
        }

        // POST: /Perfil/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Perfil perfil = db.Perfil.Find(id);
            db.Perfil.Remove(perfil);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
