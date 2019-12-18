using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApplication.Models;

namespace TestApplication.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeDbcontext db = new EmployeeDbcontext();

        public ActionResult Index()
        {
            return View();
        }

        private IEnumerable<SelectListItem> GetCityDropDownValue()
        {
            return new[]
            {
               new SelectListItem {Value ="MU", Text="Mumbai"},
                new SelectListItem {Value ="DL", Text="Delhi"},
                 new SelectListItem {Value ="CH", Text="Chennai"},
                 new SelectListItem {Value ="KL", Text="Kolkata"}
                // some lines skipped
            };
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var model = new Employee();
            model.CityDropDown = GetCityDropDownValue();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult About(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employee.Add(employee);
                db.SaveChanges();
                return Redirect("InsertEmployee");
            }

            return View(employee);
        }

        public void  InsertEmployee(Employee emp)
        {
            var name = emp.EmployeeName;
            var id = emp.EmplyeeID;
            var city = emp.City;
            var email = emp.Email;
            var phoneno = emp.PhoneNo;
            SqlConnection con = new SqlConnection("Server=ARUN-SUBBURAJ/SQLEXPRESS;Database=testdb;User Id=Arun;Password = @ruN; ");

            try
            {
                SqlCommand cmd = new SqlCommand("sp_Employee_Add", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emp_Name", name);
                cmd.Parameters.AddWithValue("@City",city);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNo", phoneno);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                //return ("Data save Successfully");
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                //return (ex.Message.ToString());
            }
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