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
    public class TestPriceController : Controller
    {
        private readonly ITestPriceProvider testPriceProvider;

        public TestPriceController(ITestPriceProvider testPriceProvider)
        {
            this.testPriceProvider = testPriceProvider;
        }

        public IActionResult AddTestPrice(TestPrice obj)
        {
            testPriceProvider.AddTestPrice(obj);
            return Ok("Data has been save succesfully");
        }
        public IActionResult DeleteTestPrice(string ID)
        {
            testPriceProvider.DeleteTestPrice(ID);
            return Ok("Data has been deleted successfully");
        }
        public IActionResult GetTestPrices()
        {
            return Ok(testPriceProvider.GetTestPrices());
        }
        public IActionResult GetTestPriceByID(string ID)
        {
            return Ok(testPriceProvider.GetTestPriceByID(ID));
        }
    }
}
