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
    public class TestController : Controller
    {
        private readonly ITestProvider testProvider;

        public TestController(ITestProvider testProvider)
        {
            this.testProvider = testProvider;
        }
        [Route("AddTest")]
        [HttpPost]
        public IActionResult AddTest(Test obj)
        {
            testProvider.AddTest(obj);
            return Ok("Data has been saved successfully");
        }
        [Route("DeleteTest")]
        [HttpPost]
        public IActionResult DeleteTest(string ID)
        {
            testProvider.DeleteTest(ID);
            return Ok("Data has been deleted successfully");
        }
        [Route("GetTests")]
        [HttpGet]
        public IActionResult GetTests()
        {
            return Ok(testProvider.GetTests());
        }
        [Route("GetTestByID")]
        [HttpGet]
        public IActionResult GetTestByID(string ID)
        {
            return Ok(testProvider.GetTestByID(ID));
        }
    }
}
