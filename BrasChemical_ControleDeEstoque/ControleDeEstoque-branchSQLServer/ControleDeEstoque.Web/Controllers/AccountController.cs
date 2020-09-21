using ControleDeEstoque.Web.DAL;
using ControleDeEstoque.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ControleDeEstoque.Web.Controllers
{
    public class AccountController : Controller
    {
        private ControleEstoqueContext db = new ControleEstoqueContext();
        SessionContext context = new SessionContext();

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            if (user.Username == "estoque" && user.Password == "3636")
            {

            }
            else
            {
                user = null;
            }

            var authenticatedUser = user;
            if (authenticatedUser != null)
            {
                context.SetAuthenticationToken(authenticatedUser.UserID.ToString(), true, authenticatedUser);
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }

}