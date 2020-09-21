using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;
using System.Web.Mvc;
using ControleDeEstoque.Web.Models;
using ControleDeEstoque.Web.Helpers;
using ControleDeEstoque.Web.Controllers.Base;
using ControleDeEstoque.Web.DAL;

namespace ControleDeEstoque.Web.Controllers
{
    public class OrdemFabricacaoController : BaseController
    {
        // GET: /OrdemFabricacao/
        public ActionResult Index()
        {
            var ordensfabricacao = db.OrdensFabricacao.Include(o => o.PreProduto);
            return View(ordensfabricacao.ToList());
        }

        public ActionResult ListaAjax()
        {

            return View(new List<OrdemFabricacao>());
        }

        [HttpPost]
        public JsonResult LoadData()
        {
            try
            {

                var draw = Request.Form.GetValues("draw").FirstOrDefault();
                var start = Request.Form.GetValues("start").FirstOrDefault();
                var length = Request.Form.GetValues("length").FirstOrDefault();
                var sortColumn = Request.Form.GetValues("columns[" + Request.Form.GetValues("order[0][column]").FirstOrDefault() + "][name]").FirstOrDefault();
                var sortColumnDir = Request.Form.GetValues("order[0][dir]").FirstOrDefault();
                var searchValue = Request.Form.GetValues("search[value]").FirstOrDefault();


                //Paging Size (10,20,50,100)    
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                // Getting all Customer data    
                var customerData = (from tempcustomer in db.OrdensFabricacao.AsNoTracking()
                                    select new
                                    {
                                        tempcustomer.LoteID,
                                        tempcustomer.PreProduto.Nome,
                                        tempcustomer.Data,
                                        tempcustomer.Envasado,
                                        tempcustomer.DataProducao
                                    });

                //Sorting    
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDir)))
                {
                    customerData = customerData.OrderBy(sortColumn + " " + sortColumnDir);
                }
                //Search    
                if (!string.IsNullOrEmpty(searchValue))
                {
                    customerData = customerData.Where(m => m.LoteID.Contains(searchValue) || m.Nome.Contains(searchValue));
                }

                //total number of rows count     
                recordsTotal = customerData.Count();
                //Paging     
                var data = customerData
                            //.Select(x => new {
                            //    x.LoteID, 
                            //    x.PreProduto.Nome,
                            //    x.Data,
                            //    x.Envasado,
                            //    x.DataProducao
                            //})
                            .Skip(skip)
                            .Take(pageSize)
                            .ToList();
                //Returning Json Data    
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });

            }
            catch (Exception)
            {
                throw;
            }

        }

        // GET: /OrdemFabricacao/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdemFabricacao ordemfabricacao = db.OrdensFabricacao.Find(id);
            if (ordemfabricacao == null)
            {
                return HttpNotFound();
            }
            return View(ordemfabricacao);
        }

        // GET: /OrdemFabricacao/Create
        public ActionResult Create()
        {
            var listaPreProdutos = (from x 
                                    in db.PreProdutos
                                    orderby x.Nome
                                    select new
                                    {
                                        x.Nome,
                                        x.PreProdutoID
                                    });

            ViewBag.PreProdutoID = new SelectList(listaPreProdutos, "PreProdutoID", "Nome");

            string lastLOTE = db.OrdensFabricacao.OrderByDescending(x => x.LoteID).Select(x => x.LoteID).FirstOrDefault();
            OrdemFabricacao ordemFabricacao = new OrdemFabricacao();

            if (String.IsNullOrEmpty(lastLOTE))
            {
                ordemFabricacao.LoteID = Helper.GetFirstLote();
            }
            else
            {
                ordemFabricacao.LoteID = Helper.GetNextLote(lastLOTE);
            }

            return View(ordemFabricacao);
        }

        // POST: /OrdemFabricacao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LoteID,PreProdutoID,Data,Envasado,DataProducao")] OrdemFabricacao ordemfabricacao)
        {
            if (ModelState.IsValid)
            {
                db.OrdensFabricacao.Add(ordemfabricacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PreProdutoID = new SelectList(db.PreProdutos.OrderBy(x => x.Nome), "PreProdutoID", "Nome", ordemfabricacao.PreProdutoID);
            return View(ordemfabricacao);
        }

        // GET: /OrdemFabricacao/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdemFabricacao ordemfabricacao = db.OrdensFabricacao.Find(id);
            if (ordemfabricacao == null)
            {
                return HttpNotFound();
            }
            ViewBag.PreProdutoID = new SelectList(db.PreProdutos.OrderBy(x => x.Nome), "PreProdutoID", "Nome", ordemfabricacao.PreProdutoID);
            return View(ordemfabricacao);
        }

        // POST: /OrdemFabricacao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LoteID,PreProdutoID,Data,Envasado,DataProducao")] OrdemFabricacao ordemfabricacao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ordemfabricacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PreProdutoID = new SelectList(db.PreProdutos.OrderBy(x => x.Nome), "PreProdutoID", "Nome", ordemfabricacao.PreProdutoID);
            return View(ordemfabricacao);
        }

        // GET: /OrdemFabricacao/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdemFabricacao ordemfabricacao = db.OrdensFabricacao.Find(id);
            if (ordemfabricacao == null)
            {
                return HttpNotFound();
            }
            return View(ordemfabricacao);
        }

        // POST: /OrdemFabricacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            OrdemFabricacao ordemfabricacao = db.OrdensFabricacao.Find(id);
            db.OrdensFabricacao.Remove(ordemfabricacao);
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
