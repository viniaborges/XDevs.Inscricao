using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Xdevs.Inscricao.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.Admin admin, string ReturnUrl)
        {
            if (IsValid(admin))
            {
                FormsAuthentication.SetAuthCookie(admin.UserName, false);
                return Redirect(ReturnUrl);
            }
            else
            {
                return View(admin);
            }
        }

        private bool IsValid(Models.Admin admin)
        {
            return (admin.UserName == "admin" && admin.Password == "nimda");
        }
    }
}