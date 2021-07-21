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
    public class Tb_PacienteController : Controller
    {
        private HundeDBEntities db = new HundeDBEntities();

        // GET: Tb_Paciente
        public ActionResult Index()
        {
            return View(db.Tb_Paciente.ToList());
        }

        // GET: Tb_Paciente/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Paciente tb_Paciente = db.Tb_Paciente.Find(id);
            if (tb_Paciente == null)
            {
                return HttpNotFound();
            }
            return View(tb_Paciente);
        }

        // GET: Tb_Paciente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tb_Paciente/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cod_pac,nom_pac,tipo_pac,raza,fec_nac_pac,sexo,color,longitud,peso,ult_vis_pac,foto,observaciones_pac,est_pac")] Tb_Paciente tb_Paciente)
        {
            if (ModelState.IsValid)
            {
                db.Tb_Paciente.Add(tb_Paciente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_Paciente);
        }

        // GET: Tb_Paciente/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Paciente tb_Paciente = db.Tb_Paciente.Find(id);
            if (tb_Paciente == null)
            {
                return HttpNotFound();
            }
            return View(tb_Paciente);
        }

        // POST: Tb_Paciente/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cod_pac,nom_pac,tipo_pac,raza,fec_nac_pac,sexo,color,longitud,peso,ult_vis_pac,foto,observaciones_pac,est_pac")] Tb_Paciente tb_Paciente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Paciente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_Paciente);
        }

        // GET: Tb_Paciente/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Paciente tb_Paciente = db.Tb_Paciente.Find(id);
            if (tb_Paciente == null)
            {
                return HttpNotFound();
            }
            return View(tb_Paciente);
        }

        // POST: Tb_Paciente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Tb_Paciente tb_Paciente = db.Tb_Paciente.Find(id);
            db.Tb_Paciente.Remove(tb_Paciente);
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
