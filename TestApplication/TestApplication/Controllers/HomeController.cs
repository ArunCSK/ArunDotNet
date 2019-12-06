using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestApplication.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        [HttpGet]
        public JsonResult GetArraySize(int size)
        {
            ViewBag.ArraySize = size;
            return Json(size, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SortArray(string[] array)
        {
            int len = array.Length;
            int temp = 0;
            int[] a = new int[len];
            for (int i = 0; i < len; i++)
            {
                a[i] = Convert.ToInt32(array[i]);
            }
            for (int i = 0; i <= len; i++)
            {
                for (int j = i+i; j < len; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return Json(a, JsonRequestBehavior.AllowGet);
        }
    }
}