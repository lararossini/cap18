﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;


namespace SalesWebMvc.Controllers
{
    public class DepartmentsController1 : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { id = 1, Name = "Eletronics" });
            list.Add(new Department { id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}
