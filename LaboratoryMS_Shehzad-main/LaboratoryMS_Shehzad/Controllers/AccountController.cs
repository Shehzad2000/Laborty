using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace LaboratoryMS_Shehzad.Controllers
{
    public class AccountController : Controller
    {
        private IConfiguration _IConfiguration;
        public AccountController(IConfiguration _config)
        {
            _IConfiguration = _config;
        }
        public IActionResult Login()
        {
            return View();
        }
        public JsonResult GETAPIUrl()
        {
            return Json(_IConfiguration.GetSection("LogConfig")["BaseHostedURL"].ToString());
        }
    }
}
