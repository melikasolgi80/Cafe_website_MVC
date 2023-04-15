using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Cafe_MVC.Models;

namespace Cafe_MVC.ViewComponents
{
    public class Section2ViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Section2s = new List<Section2>
           {
            new Section2("دمنوش","4859.jpg"),
             new Section2("هات چاکلت", "784.jpg"),
               new Section2("قهوه", "5446.jpg"),
                 new Section2("لاته", "11.jpg"),
                   new Section2("چای", "215.jpg"),
                     new Section2("نسکافه", "336655.jpg"),

           };
            return View("_Section2" ,Section2s);
        }

    }
}
