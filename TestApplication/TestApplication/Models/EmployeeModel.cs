using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestApplication.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "The Employee Name is required.")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "The Employee ID is required.")]
        public int EmplyeeID { get; set; }
        [Required(ErrorMessage = "The Phone Number is required.")]
        [MinLength(10, ErrorMessage = "The Phone Number cannot be less than 10 digit")]
        [MaxLength(10, ErrorMessage = "The Phone Number cannot be more than 10 digit")]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNo { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "The Gender is required.")]
        public int Sex { get; set; }
        [Required(ErrorMessage = "The Email ID is required.")]
        [EmailAddress(ErrorMessage = "Email is incorrect")]
        public string Email { get; set; }
        [Required(ErrorMessage = "The City is required.")]
        public Dictionary<string, string> City { get; set; }
    }

    public class EmployeeDbcontext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
    }
}