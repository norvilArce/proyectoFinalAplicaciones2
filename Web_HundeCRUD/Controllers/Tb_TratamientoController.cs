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
    public class Tb_TratamientoController : Controller
    {
        private HundeDBEntities db = new HundeDBEntities();

        // GET: Tb_Tratamiento
        public ActionResult Index()
        {
            return View(db.Tb_Tratamiento.ToList());
        }

        // GET: Tb_Tratamiento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Tratamiento tb_Tratamiento = db.Tb_Tratamiento.Find(id);
            if (tb_Tratamiento == null)
            {
                return HttpNotFound();
            }
            return View(tb_Tratamiento);
        }

        // GET: Tb_Tratamiento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tb_Tratamiento/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cod_trat,tipo_trat,nombre_trat,cod_cat_trat,estado_trat")] Tb_Tratamiento tb_Tratamiento)
        {
            if (ModelState.IsValid)
            {
                db.Tb_Tratamiento.Add(tb_Tratamiento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_Tratamiento);
        }

        // GET: Tb_Tratamiento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Tratamiento tb_Tratamiento = db.Tb_Tratamiento.Find(id);
            if (tb_Tratamiento == null)
            {
                return HttpNotFound();
            }
            return View(tb_Tratamiento);
        }

        // POST: Tb_Tratamiento/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cod_trat,tipo_trat,nombre_trat,cod_cat_trat,estado_trat")] Tb_Tratamiento tb_Tratamiento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Tratamiento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_Tratamiento);
        }

        // GET: Tb_Tratamiento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Tratamiento tb_Tratamiento = db.Tb_Tratamiento.Find(id);
            if (tb_Tratamiento == null)
            {
                return HttpNotFound();
            }
            return View(tb_Tratamiento);
        }

        // POST: Tb_Tratamiento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tb_Tratamiento tb_Tratamiento = db.Tb_Tratamiento.Find(id);
            db.Tb_Tratamiento.Remove(tb_Tratamiento);
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
