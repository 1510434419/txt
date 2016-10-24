using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace oppo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult welcome()
        {
            int a=100;
            int sum = 0;
            for (int i = 1; i <= a; i++)
            {
                sum += i;
            }
            ViewBag.sum = sum;
            return View();
        }
        public ActionResult List(int page=3)
        {
            string[] data = new string[] {"台风逼近广西景区关闭学校停课",
                     "广西游客超300万了"};


            ViewBag.data = data;
            ViewBag.page = page;
            return View(data);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       
    }
}