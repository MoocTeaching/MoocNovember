using Mooc.DataAccess.Context;
using Mooc.DataAccess.Entities;
using Mooc.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mooc.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly DataContext _dataContext;

        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }

        public LoginController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult loginPost(string username, string password)
        {
            User user = _dataContext.Users.FirstOrDefault(m => m.UserName == username);

            if (user != null)
            {
                string pwd = MD5Help.MD5Encoding(password, ConfigurationManager.AppSettings["sKey"].ToString());
                if (user.PassWord == pwd)
                {
                    CookieHelper.SetCookie("username", user.UserName, DateTime.Now.AddDays(7));
                    CookieHelper.SetCookie("userid", user.Id.ToString(), DateTime.Now.AddDays(7));
                    return Json(new { code = 0 });
                }
                return Json(new { code = 1, msg = "Wrong Password!" });
            }
            return Json(new { code = 1, msg = "Wrong Information" });
        }
        public ActionResult DeleteCookie()
        {
            CookieHelper.DeleteCookie("username");
            CookieHelper.DeleteCookie("userid");
            //if (Request.Cookies["username"] != null)
            //{
            //    Response.Cookies["username"].Expires = DateTime.Now.AddDays(-1);
            //}
            return Redirect("~/Login/Index");
        }
    }
}