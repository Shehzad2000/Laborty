using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryMS_Shehzad.Core.Data;
using LaboratoryMS_Shehzad.Core.Providers;
using LaboratoryMS_Shehzad.Shared.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LaboratoryMS_Shehzad.API.Controllers
{
    [ApiController]
    public class AccountController : Controller
    {
        private ICategoryProvider _ICategoryProvider;
        public AccountController(ICategoryProvider _ICategory)
        {
            _ICategoryProvider = _ICategory;
        }
        [Route("login")]
        public IActionResult Login(Account account)
        {
           Account a =  _ICategoryProvider.Login(account);
            if (a == null)
                return Ok("Login Falied");
            else
                return Ok(a);
        }
    }
}
