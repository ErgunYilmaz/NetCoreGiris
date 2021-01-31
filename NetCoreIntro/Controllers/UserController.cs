using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreIntro.Models;

namespace NetCoreIntro.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View(Users.users.ToList());
        }

    }
}
