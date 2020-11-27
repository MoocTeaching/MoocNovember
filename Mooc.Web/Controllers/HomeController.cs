﻿using Mooc.DataAccess.Service;
using Mooc.Models.Dtos.User;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Mooc.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        public HomeController(IUserService userService)
        {
            this._userService = userService;
        }

      
        public ActionResult Index()
        {
            var list = this._userService.GetList();
            List<UserDto> models = AutoMapper.Mapper.Map<List<UserDto>>(list);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}