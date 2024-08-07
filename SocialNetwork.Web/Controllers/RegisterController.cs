﻿using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Web.ViewModels.Account;

namespace SocialNetwork.Web.Controllers
{
    public class RegisterController: Controller
    {
        [Route("Register")]
        [HttpGet]
        public IActionResult Register()
        {
            return View("Home/Register");
        }

        [Route("RegisterPart2")]
        [HttpGet]
        public IActionResult RegisterPart2(RegisterViewModel model)
        {
            return View("RegisterPart2", model);
        }
    }
}
