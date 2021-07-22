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
    public class Tb_ClienteController : Controller
    {
        private HundeDBEntities db = new HundeDBEntities();

        // GET: Tb_Cliente
        public ActionResult Index()
        {
            var tb_Cliente = db.Tb_Cliente.Include(t => t.Tb_Ubigeo);
            return View(tb_Cliente.ToList());
        }

        // GET: Tb_Cliente/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Cliente tb_Cliente = db.Tb_Cliente.Find(id);
            if (tb_Cliente == null)
            {
                return HttpNotFound();
            }
            return View(tb_Cliente);
        }

        // GET: Tb_Cliente/Create
        public ActionResult Create()
        {
            ViewBag.id_ubigeo = new SelectList(db.Tb_Ubigeo, "Id_Ubigeo", "IdDepa");
            return View();
        }

        // POST: Tb_Cliente/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cod_cli,nom_cliente,ape_cliente,direccion_cliente,cel_cliente,email_cliente,es_dueno,id_ubigeo,dni_cliente,usu_reg_cli,fec_reg_cli,usu_ult_modificacion_cli,fecha_ult_modificacion_cli,estado_cli")] Tb_Cliente tb_Cliente)
        {
            if (ModelState.IsValid)
            {
                db.Tb_Cliente.Add(tb_Cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_ubigeo = new SelectList(db.Tb_Ubigeo, "Id_Ubigeo", "IdDepa", tb_Cliente.id_ubigeo);
            return View(tb_Cliente);
        }

        // GET: Tb_Cliente/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Cliente tb_Cliente = db.Tb_Cliente.Find(id);
            if (tb_Cliente == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_ubigeo = new SelectList(db.Tb_Ubigeo, "Id_Ubigeo", "IdDepa", tb_Cliente.id_ubigeo);
            return View(tb_Cliente);
        }

        // POST: Tb_Cliente/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cod_cli,nom_cliente,ape_cliente,direccion_cliente,cel_cliente,email_cliente,es_dueno,id_ubigeo,dni_cliente,usu_reg_cli,fec_reg_cli,usu_ult_modificacion_cli,fecha_ult_modificacion_cli,estado_cli")] Tb_Cliente tb_Cliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Cliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_ubigeo = new SelectList(db.Tb_Ubigeo, "Id_Ubigeo", "IdDepa", tb_Cliente.id_ubigeo);
            return View(tb_Cliente);
        }

        // GET: Tb_Cliente/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Cliente tb_Cliente = db.Tb_Cliente.Find(id);
            if (tb_Cliente == null)
            {
                return HttpNotFound();
            }
            return View(tb_Cliente);
        }

        // POST: Tb_Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Tb_Cliente tb_Cliente = db.Tb_Cliente.Find(id);
            db.Tb_Cliente.Remove(tb_Cliente);
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
