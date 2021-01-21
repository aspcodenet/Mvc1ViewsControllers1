using Microsoft.AspNetCore.Mvc;
using Mvc1ViewsControllers1.ViewModels;

namespace Mvc1ViewsControllers1.Controllers
{
    public class UserController : Controller
    {

        public IActionResult RegisterConfirmation()
        {
            return View();
        }



        // GET
        public IActionResult Create()
        {
            var viewModel = new UserCreateViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(UserCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Spara nu anv i databasen

                return RedirectToAction("RegisterConfirmation");

            }

            return View(model);
        }

    }
}