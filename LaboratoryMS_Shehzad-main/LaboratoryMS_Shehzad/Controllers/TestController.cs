﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LaboratoryMS_Shehzad.Controllers
{
    public class TestController : Controller
    {
        
        public IActionResult Test()
        {
            return View();
        }
    }
}
