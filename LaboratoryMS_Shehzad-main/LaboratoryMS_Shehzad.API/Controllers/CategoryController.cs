using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryMS_Shehzad.Core.Providers;
using LaboratoryMS_Shehzad.Shared.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LaboratoryMS_Shehzad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private ICategoryProvider _ICategoryProvider;
        public CategoryController(ICategoryProvider _ICategory)
        {
            _ICategoryProvider = _ICategory;
        }
        [Route("addCategory")]
        [HttpPost]
        public IActionResult addCategory(Category cat)
        {
            _ICategoryProvider.AddCategory(cat);
            return Ok("Data has been saved.");
        }
        [Route("deleteCategory")]
        [HttpPost]
        public IActionResult deleteCategory(string CatID)
        {
            _ICategoryProvider.DeleteCategory(CatID);
            return Ok("Data has been deleted.");
        }
        [Route("allCategory")]
        [HttpGet]
        public IActionResult allCategory()
        {
            return Ok(_ICategoryProvider.AllCategory());
        }
        [Route("categoryByID")]
        [HttpGet]
        public IActionResult categoryByID(string CatID)
        {
            return Ok(_ICategoryProvider.CategoryByID(CatID));
        }
    }
}
