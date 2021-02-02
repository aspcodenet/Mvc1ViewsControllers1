using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Mvc1ViewsControllers1.ViewModels
{
    public class UserCreateViewModel
    {
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.Password)] // ***
        public string Password { get; set; }

        [DataType(DataType.Password)] // ***
        public string ConfirmPassword { get; set; }

        public bool SendMeUpdates { get; set; }


        //STeg 2 regga stad
        public string City { get; set; }

        //STEG 3 välj leveranssätt 
        public string DeliveryMethod { get; set; }

        [HiddenInput]
        public int CurrentPhase { get; set; }

    }
}