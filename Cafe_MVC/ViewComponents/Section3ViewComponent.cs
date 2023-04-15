using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Cafe_MVC.Models;

namespace Cafe_MVC.ViewComponents
{
    public class Section3ViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Section3s = new List<Section3>
            {

          
             new Section3("موهیتو","5655.jpg"),
             new Section3("آب پرتقال","1515.jpg"),
             new Section3("آیس لاته","1588.jpg"),
             new Section3("اسموتی کیوی","8456.jpg"),
             new Section3("منگوبن","4895.jpg"),
           

            };

            //in return view ,we write the name of our viewcomponent
            return View("_Section3", Section3s);
        }
    }
}
