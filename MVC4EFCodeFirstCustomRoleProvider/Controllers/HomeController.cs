using MVC4CustomRoleProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC4CustomRoleProvider.Controllers
{
    public class HomeController : Controller
    {
        DataContext DB = new DataContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            // simulate a login

            var user = DB.Users.FirstOrDefault(x => x.Username == "AJ");

            FormsAuthentication.SetAuthCookie(user.Username, false);

            return RedirectToAction("Index");
        }


        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index");
        }


        [Authorize(Roles = "Administrator")]
        public ActionResult Secure()
        {
            return View();
        }
    }
}
