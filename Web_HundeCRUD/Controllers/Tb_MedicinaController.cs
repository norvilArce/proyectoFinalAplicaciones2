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
    public class Tb_MedicinaController : Controller
    {
        private HundeDBEntities db = new HundeDBEntities();

        // GET: Tb_Medicina
        public ActionResult Index()
        {
            var tb_Medicina = db.Tb_Medicina.Include(t => t.Tb_unidad_medida);
            return View(tb_Medicina.ToList());
        }

        // GET: Tb_Medicina/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Medicina tb_Medicina = db.Tb_Medicina.Find(id);
            if (tb_Medicina == null)
            {
                return HttpNotFound();
            }
            return View(tb_Medicina);
        }

        // GET: Tb_Medicina/Create
        public ActionResult Create()
        {
            ViewBag.cod_uni_med = new SelectList(db.Tb_unidad_medida, "cod_uni_med", "descrip_uni_med");
            return View();
        }

        // POST: Tb_Medicina/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cod_med,tipo_medicina,nombre_medicina,cod_uni_med")] Tb_Medicina tb_Medicina)
        {
            if (ModelState.IsValid)
            {
                db.Tb_Medicina.Add(tb_Medicina);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.cod_uni_med = new SelectList(db.Tb_unidad_medida, "cod_uni_med", "descrip_uni_med", tb_Medicina.cod_uni_med);
            return View(tb_Medicina);
        }

        // GET: Tb_Medicina/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Medicina tb_Medicina = db.Tb_Medicina.Find(id);
            if (tb_Medicina == null)
            {
                return HttpNotFound();
            }
            ViewBag.cod_uni_med = new SelectList(db.Tb_unidad_medida, "cod_uni_med", "descrip_uni_med", tb_Medicina.cod_uni_med);
            return View(tb_Medicina);
        }

        // POST: Tb_Medicina/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cod_med,tipo_medicina,nombre_medicina,cod_uni_med")] Tb_Medicina tb_Medicina)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Medicina).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.cod_uni_med = new SelectList(db.Tb_unidad_medida, "cod_uni_med", "descrip_uni_med", tb_Medicina.cod_uni_med);
            return View(tb_Medicina);
        }

        // GET: Tb_Medicina/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Medicina tb_Medicina = db.Tb_Medicina.Find(id);
            if (tb_Medicina == null)
            {
                return HttpNotFound();
            }
            return View(tb_Medicina);
        }

        // POST: Tb_Medicina/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Tb_Medicina tb_Medicina = db.Tb_Medicina.Find(id);
            db.Tb_Medicina.Remove(tb_Medicina);
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
