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
    public class ProdutoController : BaseController
    {
        // GET: /Produto/
        public ActionResult Index()
        {
            var produtos = db.Produtos.Include(p => p.PreProduto);
            return View(produtos.ToList());
        }

        // GET: /Produto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // GET: /Produto/Create
        public ActionResult Create()
        {
            ViewBag.PreProdutoID = new SelectList(db.PreProdutos.OrderBy(x => x.Nome), "PreProdutoID", "Nome");
            return View();
        }

        // POST: /Produto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ProdutoID,Nome,Litros,PreProdutoID")] Produto produto)
        {
            if (ModelState.IsValid)
            {
                db.Produtos.Add(produto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PreProdutoID = new SelectList(db.PreProdutos.OrderBy(x => x.Nome), "PreProdutoID", "Nome", produto.PreProdutoID);
            return View(produto);
        }

        // GET: /Produto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            ViewBag.PreProdutoID = new SelectList(db.PreProdutos.OrderBy(x => x.Nome), "PreProdutoID", "Nome", produto.PreProdutoID);
            return View(produto);
        }

        // POST: /Produto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ProdutoID,Nome,Litros,PreProdutoID")] Produto produto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PreProdutoID = new SelectList(db.PreProdutos.OrderBy(x => x.Nome), "PreProdutoID", "Nome", produto.PreProdutoID);
            return View(produto);
        }

        // GET: /Produto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: /Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Produto produto = db.Produtos.Find(id);
            db.Produtos.Remove(produto);
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
