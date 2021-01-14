using System;
using Microsoft.AspNetCore.Mvc;
using Mvc1ViewsControllers1.ViewModels;

namespace Mvc1ViewsControllers1.Controllers
{
    public class SupplierController : Controller
    {
        // GET
        public IActionResult Edit()
        {
            //ViewData["Message"] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            //ViewData["id"] = 123;
            var viewModel = new SupplierEditViewModel();
            viewModel.Id = 123;
            viewModel.Message = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            return View(viewModel);
        }
    }
}