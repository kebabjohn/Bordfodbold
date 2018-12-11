using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bordfodbold.Abstract;
using Bordfodbold.Models;

namespace Bordfodbold.Controllers {
    public class AccountController : Controller {
        private IAuhtProvider authProvider;
        public AccountController(IAuhtProvider auth) {
            authProvider = auth;
        }
        public ViewResult Login() {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl) {
            if (ModelState.IsValid) {
                if (authProvider.Authenticate(model.UserName,
                model.PassWord)) {
                    return Redirect(returnUrl ?? Url.Action("Index",
                    "Admin"));
                }
                else {
                    ModelState.AddModelError("", "Incorrect username or password");
              return View();
                }
            }
            else {
                return View();
            }
        }
    }

}
