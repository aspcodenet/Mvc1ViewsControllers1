using System;
using Microsoft.AspNetCore.Mvc;
using Mvc1ViewsControllers1.ViewModels;

namespace Mvc1ViewsControllers1.Controllers
{
    public class HelloController : Controller
    {


        // GET
        public IActionResult ViewHello()
        {
            int r = 12;

            //ViewData["Message"] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            var viewModel = new HelloViewHelloViewModel();
            viewModel.Message = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            return View(viewModel);
        }
    }
}