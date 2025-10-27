using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Automation.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}