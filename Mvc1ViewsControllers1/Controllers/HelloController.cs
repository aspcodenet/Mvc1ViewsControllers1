using System;
using Microsoft.AspNetCore.Mvc;
using Mvc1ViewsControllers1.ViewModels;

namespace Mvc1ViewsControllers1.Controllers
{
    public class HelloController : Controller
    {

        //Hello/RandomNumber
        private static Random rnd = new Random();
        public IActionResult RandomNumber()
        {
            var viewModel = new HelloRandomNumberViewModel();
            viewModel.Number = rnd.Next(1, 11);
            return View(viewModel);
        }


        public IActionResult Page1()
        {
            return View();
        }
        public IActionResult Page2()
        {
            return View();
        }



        public IActionResult UpdateDateTime()
        {
            var viewModel = new HelloUpdateDateTimeViewModel();

            viewModel.Timestamp = DateTime.Now;
            return View(viewModel);
        }


        public IActionResult ViewListData()
        {
            var viewModel = new HelloViewListDataViewModel();
            
            viewModel.Colors.Add("Svart");
            viewModel.Colors.Add("Grön");
            viewModel.Colors.Add("Röd");
            viewModel.Colors.Add("Blå");
            viewModel.Colors.Add("Vit");

            return View(viewModel);
        }



        // Hello/ViewHello
        public IActionResult ViewHello()
        {
            var viewModel = new HelloViewHelloViewModel();
            viewModel.Message = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            return View(viewModel);
        }


        public IActionResult ViewHelloBad()
        {
            ViewData["Message"] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            return View();
        }

    }
}