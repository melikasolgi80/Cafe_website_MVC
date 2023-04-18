using Cafe_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cafe_MVC.ViewComponents
{
    public class Section5ViewComponent:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var Section5s = new List<Section5>
            {


                new Section5("شیک ردفروت","16.jpg"),
                new Section5("شیک شکلاتی","284.jpg"),
                new Section5("شیک بری","1511.jpg"),
                new Section5("شیک دارک","9543.jpg"),
                new Section5("شیک نوتلا","482.jpg"),
                new Section5("شیک نسکافه","8845.jpg"),










            };

            //in return view ,we write the name of our viewcomponent
            return View("_Section5", Section5s);
        }
    }
}
