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
    public class ResultController : Controller
    {
        private readonly IResultProvider resultProvider;

        public ResultController(IResultProvider resultProvider)
        {
            this.resultProvider = resultProvider;
        }
        [Route("AddResult")]
        [HttpPost]
        public IActionResult AddResult(Result obj)
        {
            resultProvider.AddResult(obj);
            return Ok("Data has been saved successfully");
        }
        [Route("DeleteResult")]
        [HttpPost]
        public IActionResult DeleteResult(string ID)
        {
            resultProvider.DeleteResult(ID);
            return Ok("Data has been deleted successfully");
        }
        [Route("GetResults")]
        [HttpGet]
        public IActionResult GetResults()
        {
            return Ok(resultProvider.GetResults());
        }
        [Route("GetResultByID")]
        [HttpGet]
        public IActionResult GetResultByID(string ID)
        {
            return Ok(resultProvider.GetResultByID(ID));
        }
    }
}
