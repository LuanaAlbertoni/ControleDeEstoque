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
    public class RelatoriosController : BaseController
    {
        public ActionResult SaidasPorLote()
        {
            var lotes = (from a in db.Expedicoes.Include(x => x.Estoque.Produto.PreProduto)
                         select new ModelLoteProduto
                         {
                             LoteID = a.EstoqueLoteID,
                             Nome = a.Estoque.Produto.PreProduto.Nome
                         }).Distinct();


            return View(lotes);
        }

        public ActionResult SaidasPorLotePartial(string id)
        {
            var historico = db.Expedicoes.Include(x => x.Estoque.Produto).Where(x => x.EstoqueLoteID == id).ToList();

            return PartialView(historico);
        }

        public ActionResult EstoquePorLote()
        {
            var lotes = (from a in db.Estoque
                                         .Where(x => x.OrdemFabricacao.Envasado == true)
                                         .Include(x => x.Produto.PreProduto)
                         select new ModelLoteProduto
                         {
                             LoteID = a.LoteID,
                             Nome = a.Produto.PreProduto.Nome
                         }).Distinct();


            return View(lotes);
        }

        public ActionResult EstoquePorLotePartial(string id)
        {
            var historico = db.Estoque.Include(x => x.Produto).Where(x => x.LoteID == id).ToList();

            return PartialView(historico);
        }


        //Relatorio mensal ( ou por periodo especifico que eu indique) de todos os produtos fabricados nese periodo
        public ActionResult FabricadosPorPeriodo()
        {
           

            return View();
        }

        public ActionResult FabricadosPorPeriodoPartial(DateTime dataDe, DateTime dataAte)
        {
            var todos = db.OrdensFabricacao.Where(x => x.Envasado == true &&
                                                        x.DataProducao.Value >= dataDe &&
                                                        x.DataProducao.Value <= dataAte).ToList();

            return PartialView(todos);
        }


        public ActionResult FabricadosPorPeriodoDetalhado()
        {


            return View();
        }

        public ActionResult FabricadosPorPeriodoDetalhadoPartial(DateTime dataDe, DateTime dataAte)
        {
            var todos = db.Estoque.Where(x => x.OrdemFabricacao.DataProducao.HasValue &&
                                  x.OrdemFabricacao.DataProducao.Value >= dataDe &&
                                  x.OrdemFabricacao.DataProducao.Value <= dataAte).ToList();

            return PartialView(todos);
        }
    }
}