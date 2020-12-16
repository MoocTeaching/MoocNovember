using AutoMapper;
using Mooc.Dtos.User;
using Mooc.Services.Interfaces;
using Mooc.Utils;
using Mooc.Web.Areas.Admin.Attribute;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Mooc.Web.Areas.Admin.Controllers
{

    //[CheckAdminLogin]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }
        // GET: Admin/User
        public ActionResult Index()
        {
            //HttpContext.Session[]
            //var obj = Session["userid"];
            //if (obj == null)
            //{
            //    return RedirectToAction("Index", "Login");

            //}
            //return View();

            var list = _userService.GetList();

            return View(list);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> CreatePost(string username, string gender, string role, string major)
        {
            CreateOrUpdateUserDto addusr = new CreateOrUpdateUserDto();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(major))
            {
                return Json(new { code = 1, msg = "用户名，性别，角色，专业不能为空" });
            }
            else
            {
                //
                //Add user to db.
                //
                addusr.UserName = username;
                addusr.Gender = gender;
                //addusr.RoleType = ;
                addusr.Major = major;

                this._userService.Add(addusr);

                return Json(new { code = 0 });
            }
        }

        [HttpPost]

        public async Task<JsonResult> Reset(int? id)
        {
            if (id == null)
            {
                return Json(new { code = 1, msg = "用户名Id错误" });
            }
            else
            {
                var user = await this._userService.GetEditUser(id.Value);

                if (user != null)
                {
                    //Generate Random 12 digit password
                    string newpassword = Membership.GeneratePassword(12, 1);
                    string pwd = MD5Help.MD5Encoding(newpassword, ConfigurationManager.AppSettings["sKey"].ToString());
                    user.PassWord = pwd;
                    if (_userService.Update(Mapper.Map<CreateOrUpdateUserDto>(user)))
                    {
                        return Json(new { code = 0, msg = " 密码重置为" + newpassword });
                    }
                    else
                    {
                        return Json(new { code = 1, msg = "密码重置失败，检查数据库连接！" });
                    }
                }
                else
                {
                    return Json(new { code = 1, msg = "不能找到相应用户" });
                }
            }
        }
    }
}