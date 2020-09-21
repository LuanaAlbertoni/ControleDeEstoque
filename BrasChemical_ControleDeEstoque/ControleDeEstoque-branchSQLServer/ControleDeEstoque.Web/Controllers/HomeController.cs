using ControleDeEstoque.Web.Controllers.Base;
using ControleDeEstoque.Web.DAL;
using ControleDeEstoque.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleDeEstoque.Web.Controllers
{
    
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            ModelViewHome home = new ModelViewHome();

            home.LoteID = db.OrdensFabricacao.OrderByDescending(x => x.LoteID).Select(x => x.LoteID).FirstOrDefault();

            home.LotesEsperando = db.OrdensFabricacao.Where(x => x.Envasado == false).Count();
            
            int? produtosEsperando = db.Estoque.Sum(x => (int?)x.QuantidadeDisponivel);
            home.ProdutosEsperando = produtosEsperando.HasValue ? produtosEsperando.Value : 0; 

            return View(home);
        }
    }
}