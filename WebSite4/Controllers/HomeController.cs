using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var myRoleProvider = new MyRoleProvider();
            var roles = myRoleProvider.GetRolesForUser().ToList<string>();
            return View(roles);
        }
    }
}