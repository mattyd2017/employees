using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace employees.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()

        {
            List<Employee> employees = new List<Employee>();
            Employee emp  = new Employee();
            emp.Fname = "matty";
            emp.Lname = "Dee";
            emp.Salary = 120000;
            employees.Add(emp);
            Employee emp1 = new Employee();
            emp1.Fname = "Silly";
            emp1.Lname = "man";
            emp1.Salary = 0;
            employees.Add(emp1);
            Employee emp2 = new Employee();
            emp2.Fname = "john";
            emp2.Lname = "jones";
            emp2.Salary = 1000;
            employees.Add(emp2);
            return employees;

        }
    }
}