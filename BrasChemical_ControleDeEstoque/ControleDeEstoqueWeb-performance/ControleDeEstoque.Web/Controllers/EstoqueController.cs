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
using ControleDeEstoque.Web.Models.Json;

namespace ControleDeEstoque.Web.Controllers
{
    public class EstoqueController : BaseController
    {
        // GET: /Estoque/
        public ActionResult Index()
        {
            var estoque = db.Estoque.Include(e => e.OrdemFabricacao).Include(e => e.Produto).Where(x => x.QuantidadeDisponivel > 0);
            return View(estoque.ToList());
        }

        // GET: /Estoque/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estoque estoque = db.Estoque.Find(id);
            if (estoque == null)
            {
                return HttpNotFound();
            }
            return View(estoque);
        }

        // GET: /Estoque/Create
        public ActionResult SelecionarLote()
        {
            var lotesDisponiveis = db.OrdensFabricacao
                                        .Include(x => x.PreProduto)
                                        .Where(x => x.Envasado == false)
                                        .Select(x => new ViewModelOrdemFabricacao() {
                                            LoteID = x.LoteID,
                                            PreProdutoNome = x.PreProduto.Nome,
                                            Data = x.Data
                                        });

            return View(lotesDisponiveis.ToList());
        }

        // GET: /Estoque/Create
        public ActionResult Create(string LoteID)
        {
            ModelViewFabricacao fabricacao = new ModelViewFabricacao();

            fabricacao.OrdemFabricacao = db.OrdensFabricacao.Find(LoteID);
            fabricacao.OrdemFabricacao.DataProducao = DateTime.Now;

            return View(fabricacao);
        }

        // POST: /Estoque/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ModelViewFabricacao fabricacao)
        {
            if (ModelState.IsValid)
            {
                foreach (var estoque in fabricacao.Estoques.Where(x => x.QuantidadeProduzida > 0))
                {
                    estoque.QuantidadeDisponivel = estoque.QuantidadeProduzida;
                    db.Estoque.Add(estoque);
                }

                OrdemFabricacao ordem = db.OrdensFabricacao.Find(fabricacao.OrdemFabricacao.LoteID);
                ordem.Envasado = true;
                ordem.DataProducao = fabricacao.OrdemFabricacao.DataProducao;

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fabricacao);
        }

        // GET: /Estoque/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estoque estoque = db.Estoque.Find(id);
            if (estoque == null)
            {
                return HttpNotFound();
            }
            ViewBag.LoteID = new SelectList(db.OrdensFabricacao, "LoteID", "LoteID", estoque.LoteID);
            ViewBag.ProdutoID = new SelectList(db.Produtos, "ProdutoID", "Nome", estoque.ProdutoID);
            return View(estoque);
        }

        // POST: /Estoque/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ProdutoID,LoteID,QuantidadeProduzida,QuantidadeDisponivel")] Estoque estoque)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estoque).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LoteID = new SelectList(db.OrdensFabricacao, "LoteID", "LoteID", estoque.LoteID);
            ViewBag.ProdutoID = new SelectList(db.Produtos, "ProdutoID", "Nome", estoque.ProdutoID);
            return View(estoque);
        }

        // GET: /Estoque/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estoque estoque = db.Estoque.Find(id);
            if (estoque == null)
            {
                return HttpNotFound();
            }
            return View(estoque);
        }

        // POST: /Estoque/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Estoque estoque = db.Estoque.Find(id);
            db.Estoque.Remove(estoque);
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
