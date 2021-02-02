using System.ComponentModel.DataAnnotations;

namespace Mvc1ViewsControllers1.ViewModels
{
    public class QuestionSendViewModel
    {
        [EmailAddress]
        public string Email { get; set; }

        public string Text { get; set; }


        public bool ShowTheForm { get; set; }

    }
}