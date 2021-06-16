using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesiWebCore.Models;

namespace TesiWebCore.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            return View();
        }
        public IActionResult GetAllEmployees()
        {
            List<Employee> result = new List<Employee>()
            {
                new Employee()
                {
                    ID=1,
                    FirstName="Mario",
                    LastName = "Rossi"
                },
                new Employee()
                {
                    ID=2,
                    FirstName="Maria",
                    LastName = "Bianchi"
                }
            };

            return View(result);
        }
    }
}
