using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Cafe_MVC.Models;

namespace Cafe_MVC.ViewComponents
{
    public class Section4ViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Section4s = new List<Section4>
            {


                 new Section4("دارک بری","25.jpg"),
                 new Section4("کیک شکلاتی ","954.jpg"),
                 new Section4("کاپ کیک","6532.jpg"),
                 new Section4("کلاد کاکا","54216.jpg"),
                 new Section4("پنکیک کاراملی","65248.jpg"),
                 new Section4("موکا میوه ای","12.jpg"),




            };

            //in return view ,we write the name of our viewcomponent
            return View("_Section4", Section4s);
        }
    }
}
