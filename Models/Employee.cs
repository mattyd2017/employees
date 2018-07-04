using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace employees.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="please enter first name")]
        public string Fname { get; set; }
        [StringLength(5,ErrorMessage ="please enter second name")]
        public string Lname { get; set; }
       
        public decimal Salary { get; set; }
    }
}