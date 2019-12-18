using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestApplication.Models;

namespace TestApplication.Controllers
{
    public class EmployeesController : Controller
    {
        private EmployeeDbcontext db = new EmployeeDbcontext();

        // GET: Employees
        public ActionResult Index()
        {
            return View(db.Employee.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employee.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            ViewBag.Message = "Your application description page.";
            var model = new Employee();
            model.CityDropDown = GetCityDropDownValue();
            return View(model);
        }

        private IEnumerable<SelectListItem> GetCityDropDownValue()
        {
            return new []
            {
               new SelectListItem {Value ="MU", Text="Mumbai"},
                new SelectListItem {Value ="DL", Text="Delhi"},
                 new SelectListItem {Value ="CH", Text="Chennai"},
                 new SelectListItem {Value ="KL", Text="Kolkata"}
                // some lines skipped
            };
        }

        // POST: Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employee.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            InsertEmployee(employee);
            return View(employee);
        }

        public void InsertEmployee(Employee emp)
        {
            var name = emp.EmployeeName;
            var id = emp.EmplyeeID;
            var city = emp.City;
            var email = emp.Email;
            var phoneno = emp.PhoneNo;
            SqlConnection con = new SqlConnection("Data Source=ARUN-SUBBURAJ/SQLEXPRESS;Initial Catalog=testdb;User ID=arun;");

            try
            {
                SqlCommand cmd = new SqlCommand("sp_Employee_Add", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emp_Name", name);
                cmd.Parameters.AddWithValue("@City", city);
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

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employee.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employee.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employee.Find(id);
            db.Employee.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
