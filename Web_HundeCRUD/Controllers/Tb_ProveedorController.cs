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
    public class Tb_ProveedorController : Controller
    {
        private HundeDBEntities db = new HundeDBEntities();

        // GET: Tb_Proveedor
        public ActionResult Index()
        {
            return View(db.Tb_Proveedor.ToList());
        }

        // GET: Tb_Proveedor/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Proveedor tb_Proveedor = db.Tb_Proveedor.Find(id);
            if (tb_Proveedor == null)
            {
                return HttpNotFound();
            }
            return View(tb_Proveedor);
        }

        // GET: Tb_Proveedor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tb_Proveedor/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cod_prov,nom_prov,ruc_prov,direccion_prov,tel_prov,email_prov,rep_ven_prov,usu_reg_prov,fec_reg_prov,usu_ult_modificacion_prov,fecha_ult_modificacion_prov,estado_prov")] Tb_Proveedor tb_Proveedor)
        {
            if (ModelState.IsValid)
            {
                db.Tb_Proveedor.Add(tb_Proveedor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_Proveedor);
        }

        // GET: Tb_Proveedor/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Proveedor tb_Proveedor = db.Tb_Proveedor.Find(id);
            if (tb_Proveedor == null)
            {
                return HttpNotFound();
            }
            return View(tb_Proveedor);
        }

        // POST: Tb_Proveedor/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cod_prov,nom_prov,ruc_prov,direccion_prov,tel_prov,email_prov,rep_ven_prov,usu_reg_prov,fec_reg_prov,usu_ult_modificacion_prov,fecha_ult_modificacion_prov,estado_prov")] Tb_Proveedor tb_Proveedor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Proveedor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_Proveedor);
        }

        // GET: Tb_Proveedor/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Proveedor tb_Proveedor = db.Tb_Proveedor.Find(id);
            if (tb_Proveedor == null)
            {
                return HttpNotFound();
            }
            return View(tb_Proveedor);
        }

        // POST: Tb_Proveedor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Tb_Proveedor tb_Proveedor = db.Tb_Proveedor.Find(id);
            db.Tb_Proveedor.Remove(tb_Proveedor);
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
