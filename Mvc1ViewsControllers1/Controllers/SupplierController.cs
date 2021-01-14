using System;
using Microsoft.AspNetCore.Mvc;
using Mvc1ViewsControllers1.ViewModels;

namespace Mvc1ViewsControllers1.Controllers
{
    public class SupplierController : Controller
    {
        // GET
        //Supplier/Edit
        public IActionResult Edit()
        {
            //ViewData["Message"] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            //ViewData["id"] = 123;
            var viewModel = new SupplierEditViewModel();
            viewModel.Id = 123;
            viewModel.Message = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            viewModel.Colors.Add("Green");
            viewModel.Colors.Add("Red");
            viewModel.Colors.Add("Blue");
            viewModel.Colors.Add("Yellow");

            //int i = 12;
            //if (i == 12) return 1;
            //else return 123;
            //return ((i == 12) ? "2311" : "123");


            return View(viewModel);
        }

        public IActionResult Page1()
        {
            return View();
        }

    }
}