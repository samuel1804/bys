using System;
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
    public class OfertaLaboralController : Controller
    {
        private BDBoticasEntities db = new BDBoticasEntities();

        // GET: /OfertaLaboral/
        public ActionResult Index()
        {
            var ofertalaboral = db.OfertaLaboral.Include(o => o.Perfil).Include(o => o.Sucursal);
            return View(ofertalaboral.ToList());
        }

        // GET: /OfertaLaboral/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfertaLaboral ofertalaboral = db.OfertaLaboral.Find(id);
            if (ofertalaboral == null)
            {
                return HttpNotFound();
            }
            return View(ofertalaboral);
        }

        // GET: /OfertaLaboral/Create
        public ActionResult Create()
        {
            ViewBag.IdPerfil = new SelectList(db.Perfil, "IdPerfil", "Nombre");
            ViewBag.IdSucursal = new SelectList(db.Sucursal, "IdSurcursal", "Nombre");
            return View();
        }

        // POST: /OfertaLaboral/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="IdOfertaLaboral,Titulo,IdPerfil,IdSucursal,FuncionesAdicionales,TiempoValidez,FechaCrea,IdEstado")] OfertaLaboral ofertalaboral)
        {
            if (ModelState.IsValid)
            {
                db.OfertaLaboral.Add(ofertalaboral);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdPerfil = new SelectList(db.Perfil, "IdPerfil", "Nombre", ofertalaboral.IdPerfil);
            ViewBag.IdSucursal = new SelectList(db.Sucursal, "IdSurcursal", "Nombre", ofertalaboral.IdSucursal);
            return View(ofertalaboral);
        }

        // GET: /OfertaLaboral/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfertaLaboral ofertalaboral = db.OfertaLaboral.Find(id);
            if (ofertalaboral == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdPerfil = new SelectList(db.Perfil, "IdPerfil", "Nombre", ofertalaboral.IdPerfil);
            ViewBag.IdSucursal = new SelectList(db.Sucursal, "IdSurcursal", "Nombre", ofertalaboral.IdSucursal);
            return View(ofertalaboral);
        }

        // POST: /OfertaLaboral/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="IdOfertaLaboral,Titulo,IdPerfil,IdSucursal,FuncionesAdicionales,TiempoValidez,FechaCrea,IdEstado")] OfertaLaboral ofertalaboral)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ofertalaboral).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdPerfil = new SelectList(db.Perfil, "IdPerfil", "Nombre", ofertalaboral.IdPerfil);
            ViewBag.IdSucursal = new SelectList(db.Sucursal, "IdSurcursal", "Nombre", ofertalaboral.IdSucursal);
            return View(ofertalaboral);
        }

        // GET: /OfertaLaboral/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfertaLaboral ofertalaboral = db.OfertaLaboral.Find(id);
            if (ofertalaboral == null)
            {
                return HttpNotFound();
            }
            return View(ofertalaboral);
        }

        // POST: /OfertaLaboral/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OfertaLaboral ofertalaboral = db.OfertaLaboral.Find(id);
            db.OfertaLaboral.Remove(ofertalaboral);
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
