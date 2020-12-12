using Mooc.Web.Areas.Admin.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mooc.Web.Areas.Admin.Controllers
{

    [CheckAdminLogin]
    public class UserController : Controller
    {
        // GET: Admin/User
        public ActionResult Index()
        {
            //HttpContext.Session[]
            //var obj = Session["userid"];
            //if (obj == null)
            //{
            //    return RedirectToAction("Index", "Login");

            //}
            return View();
        }
    }
}