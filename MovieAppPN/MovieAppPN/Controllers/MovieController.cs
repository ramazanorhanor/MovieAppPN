﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MovieAppPN.Controllers  // MovieAppPN = project Name  
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}