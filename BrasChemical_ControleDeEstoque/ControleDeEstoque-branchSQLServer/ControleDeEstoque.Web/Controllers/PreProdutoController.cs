using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ControleDeEstoque.Web.Models;
using ControleDeEstoque.Web.DAL;
using ControleDeEstoque.Web.Controllers.Base;

namespace ControleDeEstoque.Web.Controllers
{
    public class PreProdutoController : BaseController
    {
        // GET: /PreProduto/
        public ActionResult Index()
        {
            return View(db.PreProdutos.OrderBy(x => x.Nome).ToList());
        }

        // GET: /PreProduto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PreProduto preproduto = db.PreProdutos.Find(id);
            if (preproduto == null)
            {
                return HttpNotFound();
            }
            return View(preproduto);
        }

        // GET: /PreProduto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /PreProduto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="PreProdutoID,Nome,Sigla")] PreProduto preproduto)
        {
            if (ModelState.IsValid)
            {
                db.PreProdutos.Add(preproduto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(preproduto);
        }

        // GET: /PreProduto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PreProduto preproduto = db.PreProdutos.Find(id);
            if (preproduto == null)
            {
                return HttpNotFound();
            }
            return View(preproduto);
        }

        // POST: /PreProduto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="PreProdutoID,Nome,Sigla")] PreProduto preproduto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(preproduto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(preproduto);
        }

        // GET: /PreProduto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PreProduto preproduto = db.PreProdutos.Find(id);
            if (preproduto == null)
            {
                return HttpNotFound();
            }
            return View(preproduto);
        }

        // POST: /PreProduto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PreProduto preproduto = db.PreProdutos.Find(id);
            db.PreProdutos.Remove(preproduto);
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
