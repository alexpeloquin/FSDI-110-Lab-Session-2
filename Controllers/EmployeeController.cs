using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;

namespace Restaurant.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index(){
            return View();
        }

        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public string Create([FromBody]Employee newEmp){
            Console.WriteLine("*************************");
            Console.WriteLine("Creating" + newEmp.Name);
            Console.WriteLine("Salary" + newEmp.Salary);
            Console.WriteLine("*************************");
            return "Okay";
        }
    }
}