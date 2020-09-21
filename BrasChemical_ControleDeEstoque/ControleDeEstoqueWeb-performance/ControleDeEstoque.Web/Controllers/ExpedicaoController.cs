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
            var listaProdutosComEstoque = db.Estoque.Where(x => x.QuantidadeDisponivel > 0)
                                                   .Select(x => new ModelViewProdutoComEstoque()
                                                   {
                                                       ProdutoID = x.ProdutoID,
                                                       ProdutoNome = x.Produto.Nome,
                                                       ProdutoLitros = x.Produto.Litros,
                                                       QuantidadeDisponivel = x.QuantidadeDisponivel,
                                                       LoteID = x.LoteID
                                                   })
                                                   .ToList();
            
            return View(listaProdutosComEstoque);
        }

        public ActionResult BuscaRapida(string LoteExpedido)
        {
            var listaProdutosComEstoque = db.Estoque.Where(x => x.QuantidadeDisponivel > 0)
                                                   .Select(x => new ModelViewProdutoComEstoque()
                                                   {
                                                       ProdutoID = x.ProdutoID,
                                                       ProdutoNome = x.Produto.Nome,
                                                       ProdutoLitros = x.Produto.Litros,
                                                       QuantidadeDisponivel = x.QuantidadeDisponivel,
                                                       LoteID = x.LoteID
                                                   })
                                                   .ToList();

            if (!string.IsNullOrEmpty(LoteExpedido))
            {
                ViewBag.LoteExpedido = LoteExpedido;
            }

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
                    EstoqueProdutoID = item.ProdutoID,
                    Quantidade = item.QuantidadeExpedida
                };
                db.Expedicoes.Add(exped);

                var estoque = db.Estoque.Find(item.LoteID, item.ProdutoID);
                estoque.QuantidadeDisponivel -= item.QuantidadeExpedida;

                db.SaveChanges();

                lote = item.LoteID;
            }
            string LoteExpedido = lote;


            return RedirectToAction("BuscaRapida", new { LoteExpedido = LoteExpedido });

        }

        // POST: /Expedicao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ModelViewProdutoComEstoque[] Expedicao)
        {
            string lote = String.Empty;

            foreach (var item in Expedicao.Where(x => x.QuantidadeExpedida > 0))
            {
                Expedicao exped = new Expedicao()
                {
                    Data = DateTime.Now,
                    EstoqueLoteID = item.LoteID,
                    EstoqueProdutoID = item.ProdutoID,
                    Quantidade = item.QuantidadeExpedida
                };
                db.Expedicoes.Add(exped);

                var estoque = db.Estoque.Find(item.LoteID, item.ProdutoID);
                estoque.QuantidadeDisponivel -= item.QuantidadeExpedida;

                db.SaveChanges();

                lote = item.LoteID;
            }
            string mensagemLote = "Lote " + lote + " expedido com sucesso";


            return RedirectToAction("ProdutosComEstoque", new { msg = mensagemLote });
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
