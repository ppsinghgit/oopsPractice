using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WroxAuthorization.Models;

namespace WroxAuthorization.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginModel loginModel)
        {
            FormsAuthentication.SetAuthCookie(loginModel.UserName, false);
            //var authTicket = new FormsAuthenticationTicket(1, loginModel.UserName, DateTime.Now, DateTime.Now.AddMinutes(20), false, "Admin");
            //string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
            //var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            //HttpContext.Response.Cookies.Add(authCookie);
            return Redirect("~/Home/LoggedIn");
        }

        [Authorize]
        public ActionResult LoggedIn()
        {
            return View();
        }
    }
}