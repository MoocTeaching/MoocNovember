using Mooc.DataAccess.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mooc.Web.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(UserDto user )
        {
            TempData["ErrorMesssage"] = "用户名或者密码错误";
            return RedirectToAction("Index");

            //return Redirect("/Home/Index");
        }
    }


}