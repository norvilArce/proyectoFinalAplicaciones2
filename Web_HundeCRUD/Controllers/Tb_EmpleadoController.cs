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
    public class Tb_EmpleadoController : Controller
    {
        private HundeDBEntities db = new HundeDBEntities();

        // GET: Tb_Empleado
        public ActionResult Index()
        {
            return View(db.Tb_Empleado.ToList());
        }

        // GET: Tb_Empleado/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Empleado tb_Empleado = db.Tb_Empleado.Find(id);
            if (tb_Empleado == null)
            {
                return HttpNotFound();
            }
            return View(tb_Empleado);
        }

        // GET: Tb_Empleado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tb_Empleado/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cod_emp,rol_emp,nom_empleado,ape_empleado,fecha_ingreso,sueldo,email_emp,cod_supervisor,usu_ult_modificacion_emp,fecha_ult_modificacion_emp,estado_emp")] Tb_Empleado tb_Empleado)
        {
            if (ModelState.IsValid)
            {
                db.Tb_Empleado.Add(tb_Empleado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_Empleado);
        }

        // GET: Tb_Empleado/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Empleado tb_Empleado = db.Tb_Empleado.Find(id);
            if (tb_Empleado == null)
            {
                return HttpNotFound();
            }
            return View(tb_Empleado);
        }

        // POST: Tb_Empleado/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cod_emp,rol_emp,nom_empleado,ape_empleado,fecha_ingreso,sueldo,email_emp,cod_supervisor,usu_ult_modificacion_emp,fecha_ult_modificacion_emp,estado_emp")] Tb_Empleado tb_Empleado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Empleado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_Empleado);
        }

        // GET: Tb_Empleado/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Empleado tb_Empleado = db.Tb_Empleado.Find(id);
            if (tb_Empleado == null)
            {
                return HttpNotFound();
            }
            return View(tb_Empleado);
        }

        // POST: Tb_Empleado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Tb_Empleado tb_Empleado = db.Tb_Empleado.Find(id);
            db.Tb_Empleado.Remove(tb_Empleado);
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
