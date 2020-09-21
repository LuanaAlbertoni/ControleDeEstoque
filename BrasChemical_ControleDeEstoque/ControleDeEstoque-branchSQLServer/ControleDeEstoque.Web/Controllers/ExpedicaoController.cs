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
    public class ExpedicaoController : BaseController
    {
        // GET: /Expedicao/
        public ActionResult Index()
        {
            return View(db.Expedicoes.ToList());
        }

        // GET: /Expedicao/Create
        public ActionResult ProdutosComEstoque()
        {
            List<ModelViewProdutoComEstoque> listaProdutosComEstoque = new List<ModelViewProdutoComEstoque>();
            ModelViewProdutoComEstoque model;

            var prodsEmEstoque = db.Estoque.Where(x => x.QuantidadeDisponivel > 0).GroupBy(x => x.ProdutoID).ToList();

            foreach (var item in prodsEmEstoque)
            {
                foreach (var itemEstoque in item)
                {
                    model = new ModelViewProdutoComEstoque();
                    model.Produto = db.Produtos.Find(item.Key);

                    model.LoteID = itemEstoque.LoteID;
                    model.QuantidadeDisponivel = itemEstoque.QuantidadeDisponivel;

                    listaProdutosComEstoque.Add(model);
                }
            }

            //ViewBag.ProdutoID = new SelectList(db.Estoque.Where(x => x.QuantidadeDisponivel > 0), "ProdutoID", "Nome");

            return View(listaProdutosComEstoque);
        }

        public ActionResult BuscaRapida(string msg)
        {
            List<ModelViewProdutoComEstoque> listaProdutosComEstoque = new List<ModelViewProdutoComEstoque>();
            ModelViewProdutoComEstoque model;

            var prodsEmEstoque = db.Estoque.Where(x => x.QuantidadeDisponivel > 0).GroupBy(x => x.ProdutoID).ToList();

            foreach (var item in prodsEmEstoque)
            {
                foreach (var itemEstoque in item)
                {
                    model = new ModelViewProdutoComEstoque();
                    model.Produto = db.Produtos.Find(item.Key);

                    model.LoteID = itemEstoque.LoteID;
                    model.QuantidadeDisponivel = itemEstoque.QuantidadeDisponivel;

                    listaProdutosComEstoque.Add(model);
                }
            }

            if (!string.IsNullOrEmpty(msg))
            {
                ViewBag.MensagemLote = msg;
            }
            //ViewBag.ProdutoID = new SelectList(db.Estoque.Where(x => x.QuantidadeDisponivel > 0), "ProdutoID", "Nome");

            return View(listaProdutosComEstoque);
        }

        public ActionResult Ultimas()
        {
            return PartialView(db.Expedicoes.OrderByDescending(x => x.Data).Take(20).ToList());
        }

        // POST: /Expedicao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BuscaRapida(ModelViewProdutoComEstoque[] Expedicao)
        {
            string lote = String.Empty;

            foreach (var item in Expedicao.Where(x => x.QuantidadeExpedida > 0))
            {
                Expedicao exped = new Expedicao()
                {
                    Data = DateTime.Now,
                    EstoqueLoteID = item.LoteID,
                    EstoqueProdutoID = item.Produto.ProdutoID,
                    Quantidade = item.QuantidadeExpedida
                };
                db.Expedicoes.Add(exped);

                var estoque = db.Estoque.Find(item.LoteID, item.Produto.ProdutoID);
                estoque.QuantidadeDisponivel -= item.QuantidadeExpedida;

                db.SaveChanges();

                lote = item.LoteID;
            }
            string mensagemLote = "Lote " + lote + " expedido com sucesso";


            return RedirectToAction("BuscaRapida", new { msg = mensagemLote });

        }

        // GET: /Expedicao/Create
        public ActionResult Create()
        {
            List<ModelViewProdutoComEstoque> listaProdutosComEstoque = new List<ModelViewProdutoComEstoque>();
            ModelViewProdutoComEstoque model;

            foreach (var item in db.Estoque.Where(x => x.QuantidadeDisponivel > 0).GroupBy(x => x.ProdutoID))
            {
                foreach (var itemEstoque in item)
                {
                    model = new ModelViewProdutoComEstoque();
                    model.Produto = db.Produtos.Find(item.Key);

                    model.LoteID = itemEstoque.LoteID;
                    model.QuantidadeDisponivel = itemEstoque.QuantidadeDisponivel;

                    listaProdutosComEstoque.Add(model);
                }
            }

            //ViewBag.ProdutoID = new SelectList(db.Estoque.Where(x => x.QuantidadeDisponivel > 0), "ProdutoID", "Nome");

            return View(listaProdutosComEstoque);
        }

        // POST: /Expedicao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ModelViewProdutoComEstoque[] Expedicao)
        {
            if (ModelState.IsValid)
            {
                foreach (var item in Expedicao.Where(x => x.QuantidadeExpedida > 0))
                {
                    Expedicao exped = new Expedicao()
                    {
                        Data = DateTime.Now,
                        EstoqueLoteID = item.LoteID,
                        EstoqueProdutoID = item.Produto.ProdutoID,
                        Quantidade = item.QuantidadeExpedida
                    };
                    db.Expedicoes.Add(exped);

                    var estoque = db.Estoque.Find(item.LoteID, item.Produto.ProdutoID);
                    estoque.QuantidadeDisponivel -= item.QuantidadeExpedida;

                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }

            return View("ProdutosComEstoque", Expedicao);
        }

        // GET: /Expedicao/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expedicao expedicao = db.Expedicoes.Find(id);
            if (expedicao == null)
            {
                return HttpNotFound();
            }
            return View(expedicao);
        }

        // POST: /Expedicao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ExpedicaoID,EstoqueLote,EstoqueProdutoID,Data,Quantidade")] Expedicao expedicao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expedicao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expedicao);
        }

        // GET: /Expedicao/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expedicao expedicao = db.Expedicoes.Find(id);
            if (expedicao == null)
            {
                return HttpNotFound();
            }
            return View(expedicao);
        }

        // POST: /Expedicao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Expedicao expedicao = db.Expedicoes.Find(id);
            db.Expedicoes.Remove(expedicao);
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
