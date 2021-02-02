using Microsoft.AspNetCore.Mvc;
using Mvc1ViewsControllers1.ViewModels;

namespace Mvc1ViewsControllers1.Controllers
{
    public class QuestionController : Controller
    {
        // GET
        public IActionResult Send()
        {
            var viewModel = new QuestionSendViewModel();
            viewModel.ShowTheForm = true;
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Send(QuestionSendViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                viewModel.ShowTheForm = false;
                return View(viewModel);
            }
            viewModel.ShowTheForm = true;
            return View(viewModel);
        }

    }
}