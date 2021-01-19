using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Mvc1ViewsControllers1.ViewModels
{
    public class NewsIndexViewModel
    {
        public class NewsItem
        { 
            public int Id { get; set; }
            public string Headline { get; set; }
            public string Text { get; set; }
        }


        public List<NewsItem> Items { get; set; } = new List<NewsItem>();
    }

}