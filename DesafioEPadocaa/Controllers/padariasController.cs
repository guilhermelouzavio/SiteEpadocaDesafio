using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DesafioEPadocaa.Models;

namespace DesafioEPadocaa.Controllers
{
    public class padariasController : Controller
    {
        private contexto db = new contexto();

        // GET: padarias
        public ActionResult Index()
        {
            return View(db.Padarias.ToList());
        }

        // GET: padarias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            padaria padaria = db.Padarias.Find(id);
            if (padaria == null)
            {
                return HttpNotFound();
            }
            return View(padaria);
        }

        // GET: padarias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: padarias/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "codigo,nome,telefone,endereco,cnpj")] padaria padaria)
        {

            if (ModelState.IsValid)
            {
                db.Padarias.Add(padaria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(padaria);
        }

        // GET: padarias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            padaria padaria = db.Padarias.Find(id);
            if (padaria == null)
            {
                return HttpNotFound();
            }
            return View(padaria);
        }

        // POST: padarias/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "codigo,nome,telefone,endereco,cnpj")] padaria padaria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(padaria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(padaria);
        }

        // GET: padarias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            padaria padaria = db.Padarias.Find(id);
            if (padaria == null)
            {
                return HttpNotFound();
            }
            return View(padaria);
        }

        // POST: padarias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            padaria padaria = db.Padarias.Find(id);
            db.Padarias.Remove(padaria);
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
