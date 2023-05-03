using Cafe_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace Cafe_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>
        {
                new Service(1 , "رزرو تولد"),
                new Service(2 , "خرید انلاین قهوه ارگانیک"),
                new Service(3 , "ثبت انتقادات و پیشنهادات"),
        };

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact()
            {
                Services = new SelectList(_services,"Id" ,"Name")
            };
            return View(model);
        }


        //[HttpPost]
        // public JsonResult Contact(IFormCollection Form)
        //  {
        //      var name = Form["name"];
        //      return Json(Ok());
        //  }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Services= new SelectList(_services , "Id" ,"Name");
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست.لطفا دوباره تلاش کنید";
                return View(model);
            }

            ModelState.Clear();

            model = new Contact()
            {
                Services = new SelectList(_services, "Id", "Name")
            };

            ViewBag.success = "پیغام شما با موفقیت ارسال شد .با تشکر";
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}