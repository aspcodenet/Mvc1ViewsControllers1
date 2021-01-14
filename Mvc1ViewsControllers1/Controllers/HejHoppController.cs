using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mvc1ViewsControllers1.Controllers
{
    public class HejHoppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
