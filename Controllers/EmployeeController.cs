using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using employees.Models;
using employees.ViewModels;

namespace employees.Controllers
{
    public class EmployeeController : Controller
    {
        private salesEntities1 db = new salesEntities1();
        // GET: Employee
        public ActionResult Index()
        {
            //Employee emp = new Employee();
            //emp.Fname = "mat";
            //emp.Lname = "le twat";
            //emp.Salary = 1000;
            //EmployeeViewModel vmemp = new EmployeeViewModel();
            //vmemp.EmployeeName = emp.Fname + " " + emp.Lname;
            //vmemp.Salary = emp.Salary;

            //if(emp.Salary>10)
            //{
            //    vmemp.SalaryColor = "blue";
            //}
            //else
            //{
            //    vmemp.SalaryColor = "red";
            //}
            //vmemp.UserName = "MATT";
            //return View("index",vmemp);


            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();
            List<Employee> employees = db.Employees.ToList();
            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach(Employee emp in employees)
            {
                EmployeeViewModel empViewModel = new EmployeeViewModel();
                empViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
                empViewModel.Salary = emp.Salary.ToString("c");
                if(emp.Salary > 1500)
                {
                    empViewModel.SalaryColor = "green";
                }
                else
                {
                    empViewModel.SalaryColor = "red";
                }
                empViewModels.Add(empViewModel);
            }
            employeeListViewModel.Employees = empViewModels;
            employeeListViewModel.UserName = "MATTY";
            return View("Index", employeeListViewModel);
        }
        public ActionResult Addemployee()
        {
            return View();
        }
        public ActionResult SaveEmployee(Employee e, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                    if (ModelState.IsValid)
                    {
                        Employee emp = new Employee();
                        emp.FirstName = e.FirstName;
                        emp.LastName = e.LastName;
                        emp.Salary = e.Salary;
                        db.Employees.Add(emp);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View("AddEmployee");
                    }

                case "Cancel":
                    return RedirectToAction("Index");
            }
            return new EmptyResult();
        }

    }
}