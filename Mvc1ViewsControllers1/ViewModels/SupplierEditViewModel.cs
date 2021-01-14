using System.Collections.Generic;

namespace Mvc1ViewsControllers1.ViewModels
{
    public class SupplierEditViewModel
    {
        public string Message { get; set; }
        public int Id { get; set; }

        public List<string> Colors { get; set; } = new List<string>();
    }
}