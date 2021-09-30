using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Xdevs.Inscricao.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Register()
        {
            //ViewBag.RoleId = new SelectList(DbContext.AdminRoles, "RoleId", "RoleName");
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}