using ControleDeEstoque.Web.DAL;
using ControleDeEstoque.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleDeEstoque.Web.Controllers.Base
{
    [Authorize]
    public class BaseController : Controller
    {
        protected ControleEstoqueContext db = new ControleEstoqueContext();

        protected override JsonResult Json(object data, string contentType, System.Text.Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return new CustomJsonResult
            {
                Data = data,
                ContentType = contentType,
                ContentEncoding = contentEncoding,
                JsonRequestBehavior = behavior
            };
        }
    }
}