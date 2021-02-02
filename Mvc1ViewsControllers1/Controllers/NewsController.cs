using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mvc1ViewsControllers1.Models;
using Mvc1ViewsControllers1.ViewModels;

namespace Mvc1ViewsControllers1.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new NewsIndexViewModel();

            viewModel.Items = GetListFromDatabase().Select(databaseArticle =>
                new NewsIndexViewModel.NewsItem
                {
                    Id = databaseArticle.Id,
                    Headline = databaseArticle.Headline,
                    Text = databaseArticle.NewsText
                }
            ).ToList();

            //foreach (var databaseArticle in GetListFromDatabase())
            //{
            //    var viewModelArticle = new NewsIndexViewModel.NewsItem();
            //    viewModelArticle.Id = databaseArticle.Id;
            //    viewModelArticle.Headline = databaseArticle.Headline;
            //    viewModelArticle.Text = databaseArticle.NewsText;
            //    viewModel.Items.Add(viewModelArticle);
            //}

            return View(viewModel);
        }


        // News/Details
        public IActionResult Details(int id)
        {
            var model = GetListFromDatabase().First(r => r.Id == id);
            var viewModel = new NewsDetailsViewModel(); 
            viewModel.Headline = model.Headline;
            viewModel.NewsText = model.NewsText;
            viewModel.CurrentGrade = model.Grade;

            return View(viewModel);

        }


        public IActionResult TestUpload()
        {
            var model = new TestUploadViewModel();
            return View(model);
        }


        [HttpPost]
        public IActionResult TestUpload(FormFile FileUpload)
        {
            using (var stream = System.IO.File.Create("C:\\Users\\stefa\\aaa.jpg"))
            {
                FileUpload.CopyToAsync(stream);
            }

            return View();
        }

        /*
         *
         *
         *
         */


        private List<News> GetListFromDatabase()

        {

            var listFromDb = new List<News>();

            listFromDb.Add(new News { Id=1, Grade = 1, Headline = "Extremkyla drar in", NewsText = @"Stora snömängder i södra Sverige Redan på tisdag kommer ett lågtryck in över de södra delarna av Sverige, vilket kan orsaka stora snöfall i Götaland. Det ser att att vara rätt stora mängder. Det kan vara frågan om decimeter snö i Götaland, säger Per Holmberg, Meteorolog på Storm." });

            listFromDb.Add(new News {Id=2, Grade = 4, Headline = "Spelet bakom svenska segerrycket", NewsText = @"Svenska lagets taktik låg bakom Ebba Anderssons segerryck.



Ett upplägg man rekat och planerat för in i minsta detalj. Sportbladet har kartlagt spelet bakom segerrycket.



– Det var precis som planerat, jag bara skrek" });





            listFromDb.Add(new News { Id=3,Grade=2, Headline = "Säkerhetsanalytikerns varning: ”De säger att detta bara är början”", NewsText = @"Många av dessa personer känner att de har momentum, och säger att detta bara är början. Det kan bli en snöbollseffekt" });



            return listFromDb;


        }



    }
}