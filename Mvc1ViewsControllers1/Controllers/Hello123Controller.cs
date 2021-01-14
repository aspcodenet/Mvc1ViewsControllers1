using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc1ViewsControllers1.Controllers
{
    public class Hello123Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
