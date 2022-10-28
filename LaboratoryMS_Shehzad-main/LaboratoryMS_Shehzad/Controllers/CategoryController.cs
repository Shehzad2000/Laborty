using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LaboratoryMS_Shehzad.Controllers
{
    public class CategoryController : Controller
    {
        
        public IActionResult Category()
        {
            return View();
        }
        
    }
}
