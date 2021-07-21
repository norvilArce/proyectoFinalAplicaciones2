using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web_HundeCRUD.Models;

namespace Web_HundeCRUD.Controllers
{
    public class Tb_EstadoController : Controller
    {
        private HundeDBEntities db = new HundeDBEntities();

        // GET: Tb_Estado
        public ActionResult Index()
        {
            return View(db.Tb_Estado.ToList());
        }

        // GET: Tb_Estado/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Estado tb_Estado = db.Tb_Estado.Find(id);
            if (tb_Estado == null)
            {
                return HttpNotFound();
            }
            return View(tb_Estado);
        }

        // GET: Tb_Estado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tb_Estado/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cod_estado,conducta,est_nutricional,actividad")] Tb_Estado tb_Estado)
        {
            if (ModelState.IsValid)
            {
                db.Tb_Estado.Add(tb_Estado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_Estado);
        }

        // GET: Tb_Estado/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Estado tb_Estado = db.Tb_Estado.Find(id);
            if (tb_Estado == null)
            {
                return HttpNotFound();
            }
            return View(tb_Estado);
        }

        // POST: Tb_Estado/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cod_estado,conducta,est_nutricional,actividad")] Tb_Estado tb_Estado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Estado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_Estado);
        }

        // GET: Tb_Estado/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Estado tb_Estado = db.Tb_Estado.Find(id);
            if (tb_Estado == null)
            {
                return HttpNotFound();
            }
            return View(tb_Estado);
        }

        // POST: Tb_Estado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tb_Estado tb_Estado = db.Tb_Estado.Find(id);
            db.Tb_Estado.Remove(tb_Estado);
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
