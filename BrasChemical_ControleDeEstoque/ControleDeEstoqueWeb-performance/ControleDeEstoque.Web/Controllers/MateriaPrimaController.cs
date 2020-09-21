using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ControleDeEstoque.Web.Controllers.Base;
using ControleDeEstoque.Web.DAL;
using ControleDeEstoque.Web.Models;

namespace ControleDeEstoque.Web.Controllers
{
    public class MateriaPrimaController : BaseController
    {
        // GET: MateriaPrimas
        public ActionResult Index()
        {
            return View(db.MateriasPrimas.ToList());
        }

        // GET: MateriaPrimas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MateriaPrima materiaPrima = db.MateriasPrimas.Find(id);
            if (materiaPrima == null)
            {
                return HttpNotFound();
            }
            return View(materiaPrima);
        }

        // GET: MateriaPrimas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MateriaPrimas/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MateriaPrimaID,Nome,CAS,CodigoInterno,NCM,Densidade,Tipo")] MateriaPrima materiaPrima)
        {
            if (ModelState.IsValid)
            {
                db.MateriasPrimas.Add(materiaPrima);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(materiaPrima);
        }

        // GET: MateriaPrimas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MateriaPrima materiaPrima = db.MateriasPrimas.Find(id);
            if (materiaPrima == null)
            {
                return HttpNotFound();
            }
            return View(materiaPrima);
        }

        // POST: MateriaPrimas/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MateriaPrimaID,Nome,CAS,CodigoInterno,NCM,Densidade,Tipo")] MateriaPrima materiaPrima)
        {
            if (ModelState.IsValid)
            {
                db.Entry(materiaPrima).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(materiaPrima);
        }

        // GET: MateriaPrimas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MateriaPrima materiaPrima = db.MateriasPrimas.Find(id);
            if (materiaPrima == null)
            {
                return HttpNotFound();
            }
            return View(materiaPrima);
        }

        // POST: MateriaPrimas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            MateriaPrima materiaPrima = db.MateriasPrimas.Find(id);
            db.MateriasPrimas.Remove(materiaPrima);
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
