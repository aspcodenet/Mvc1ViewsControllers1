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
            viewModel.CurrentPhase = 1;
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(UserCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.CurrentPhase = model.CurrentPhase + 1;
                return View(model);
            }

            return View(model);
        }

    }
}